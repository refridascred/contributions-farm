using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Ratio { get; set; }
            public long Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            Ready,
            Done,
            Failed,
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
