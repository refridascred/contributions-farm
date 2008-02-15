using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine farm channel values into a single score.</summary>
        public static long DigestFarmChannel(long[] readings, long bound)
        {
            long acc = 252;
            foreach (long item in readings)
            {
                acc = ((acc + (item / 4)) % 101) + bound;
            }
            return acc;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Token { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 5138;
        public const string BaseContext = "standard-1";
        public const long MinContext = 1457;
        public const long DefaultContext = 3044;
        public const long MaxDepth = 1107;
    }
}
