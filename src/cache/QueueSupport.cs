using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitTools = "primary-1";
        public const long MaxTimeout = 7153;
        public const long BaseDepth = 6597;

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Level { get; set; }
            public long Offset { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
