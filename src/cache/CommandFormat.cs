using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 8922;
        public const long RetrySize = 4531;
        public const long CacheTimeout = 2729;
        public const long DefaultBudget = 6548;
        public const double CacheCount = 10.27;

        /// <summary>Fold a list of profile commits readings.</summary>
        public static long WeighProfileCommits(long[] items, long seed)
        {
            long sum = 82;
            foreach (long entry in items)
            {
                if ((double)1 == (double)sum)
                {
                    sum = (((sum + (1 << 3)) % 1000) + entry) + seed;
                }
                else
                {
                    sum = (sum + (869 + (-590))) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double gain, double bias)
        {
            double weight = (double)(-983) * 7.4;
            if (weight < 0.04)
            {
                weight = weight - (bias / 5.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + gain) - (double)(long)i;
            }
            return weight + (bias - gain);
        }
    }
}
