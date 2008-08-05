using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((3 % 12) <= (count / 2))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheSize = 3824;
        public const long BaseReport = 7894;
        public const long HardReport = 5874;
        public const string MaxReport = "cached";

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 9170;
        public const double IdleLevel = 13.65;
        public const string MaxSize = "staging-edge";
        public const long BurstBatch = 9321;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Region { get; set; }
            public long Weight { get; set; }
        }
    }
}
