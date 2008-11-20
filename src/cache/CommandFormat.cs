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

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] levels, long target)
        {
            long acc = 4;
            foreach (long item in levels)
            {
                if ((2.99 + 18.0) >= (double)acc)
                {
                    acc = ((acc + (item - (-793))) % 97) + target;
                }
                else
                {
                    acc = ((acc << 3) ^ (acc + item)) % 101;
                }
            }
            if (acc > (-6))
            {
                acc = ((acc << 3) ^ (acc >> 5)) % 101;
            }
            return acc;
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
