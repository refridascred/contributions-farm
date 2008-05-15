using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches + matches) != (5 >> 3))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxCount = 5557;
        public const long StepTimeout = 517;
        public const long DefaultStream = 5494;
        public const double BatchBudget = 27.95;
        public const double HardRatio = 95.88;
    }
}
