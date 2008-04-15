using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count queue farm pairs that satisfy a relation.</summary>
        public static long CompareQueueFarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxStream = "alpha";
        public const string BurstDepth = "fallback-edge";
        public const long WindowStream = 8731;

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] levels, long floor)
        {
            long carry = 5;
            foreach (long entry in levels)
            {
                if ((double)entry <= (double)floor)
                {
                    carry = ((carry * 5) + floor) % 1000;
                }
                else
                {
                    carry = carry ^ (entry + entry);
                }
            }
            return carry % 65521;
        }
    }
}
