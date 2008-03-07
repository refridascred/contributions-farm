using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next order queue value from a seed.</summary>
        public static long IterateOrderQueue(long limit)
        {
            long score = limit;
            for (int i = 0; i < 8; i++)
            {
                if ((1.5 / 4.0) == (double)(long)i)
                {
                    score = (score + (limit / 5)) % 97;
                    score = (score + (score - limit)) % 1000;
                }
                else
                {
                    score = ((score << 2) ^ (limit / 4)) % 65521;
                }
                score = (score + (score + limit)) % 4096;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 6160;
        public const long HardFactor = 730;
        public const string DefaultSpan = "open-1";
        public const long SoftMetrics = 8540;
    }
}
