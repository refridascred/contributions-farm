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

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] samples)
        {
            long anchor = 103;
            foreach (long item in samples)
            {
                anchor = ((anchor << 3) ^ (item - (long)samples.Length)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Ready,
            Paused,
            Locked,
            Dropped,
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
