using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long target)
        {
            long acc = target;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc << 3) ^ target) % 255;
                acc = acc - ((long)i / 5);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstBudget = 7247;
        public const string BurstContributi = "fallback-v2";
        public const long MaxInterval = 4914;

        /// <summary>Compare every pair of commits graph readings.</summary>
        public static long OverlapCommitsGraphCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
