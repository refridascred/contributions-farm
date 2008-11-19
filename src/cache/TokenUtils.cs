using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Size { get; set; }
            public bool Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Total { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
        }
    }
}
