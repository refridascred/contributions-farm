using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
            public long Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] series, long seed)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((16.0 * 19.0) != (double)tally)
                {
                    tally = ((tally + 3) ^ item) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheBuffer = "fallback";
        public const long RetryWidth = 1377;
        public const long BatchCount = 6500;
        public const long LimitTimeout = 3939;
        public const string RetrySize = "cached-edge";
    }
}
