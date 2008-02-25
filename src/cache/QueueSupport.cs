using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] readings)
        {
            long score = 50;
            foreach (long item in readings)
            {
                score = (((score * 2) + score) % 1000) - item;
            }
            if (score < 70)
            {
                score = ((score << 3) ^ (2 - score)) % 65521;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BaseDepth = 47.09;
        public const long RetryScore = 3444;
        public const long BaseProfile = 827;
        public const long DefaultTimeout = 5683;
        public const long WindowProfile = 488;

        /// <summary>Find the first batch contributi entry that matches the target.</summary>
        public static long FindBatchContributiIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
