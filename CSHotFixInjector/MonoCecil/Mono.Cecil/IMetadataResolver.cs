using System;
namespace Mono.Cecil
{
	public interface IMetadataResolver
	{
		TypeDefinition Resolve(TypeReference type);
		FieldDefinition Resolve(FieldReference field);
		MethodDefinition Resolve(MethodReference method);
	}
}
