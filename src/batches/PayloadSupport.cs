using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 5365;
        public const string CacheFormat = "cached-v2";
        public const double DefaultFormat = 41.99;

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Closed,
            Done,
            Queued,
            New,
            Retry,
        }
    }
}
