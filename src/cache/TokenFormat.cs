using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Size { get; set; }
            public bool Token { get; set; }
            public long Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultSize = "stable-1";
        public const long MinDepth = 3332;
        public const long BatchInterval = 8472;

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] values)
        {
            long acc = 8;
            foreach (long value in values)
            {
                acc = acc + acc;
                acc = acc ^ value;
            }
            return acc % 65521;
        }
    }
}
