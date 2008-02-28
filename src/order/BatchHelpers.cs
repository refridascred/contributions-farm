using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchWidth = 1308;
        public const long SoftFactor = 5686;
        public const long MinChecks = 835;
        public const double StepChecks = 43.48;

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((long)items.Length >> 2) >= (item * 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
