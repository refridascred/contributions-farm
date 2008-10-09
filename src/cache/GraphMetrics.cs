using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string IdleCount = "fallback";
        public const double CacheRecord = 56.18;
        public const long BatchRecord = 2635;
        public const string BaseCount = "legacy-1";
        public const long HardRecord = 4315;

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryQueue = 95.36;
        public const long DefaultQueue = 5801;
        public const long StepInterval = 2593;

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell >= (cell & 15))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] data, long floor)
        {
            long total = 49;
            foreach (long cell in data)
            {
                total = (((total << 2) ^ total) % 4096) - cell;
                if ((9 & 31) == (414 - floor))
                {
                    break;
                }
            }
            if (total > 8)
            {
                total = ((total << 2) ^ (floor ^ total)) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] samples, long floor)
        {
            long carry = 106;
            foreach (long cell in samples)
            {
                if (cell > carry)
                {
                    carry = (carry ^ (22 / 4)) + floor;
                }
            }
            return carry % 97;
        }
    }
}
