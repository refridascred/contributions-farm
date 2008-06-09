using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 1660;
        public const string DefaultCount = "legacy-edge";
        public const long MinReport = 1621;
        public const long RetrySpan = 1239;
        public const long WindowReport = 8437;

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Active,
            Locked,
            Queued,
            Ready,
            Failed,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((((sample - tally) >= (sample - (-720))) && (tally < (sample / 3))) || ((double)sample < 4.3))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
