using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public bool Total { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
