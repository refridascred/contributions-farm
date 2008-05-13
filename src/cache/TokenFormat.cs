using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
