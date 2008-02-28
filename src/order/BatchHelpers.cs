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

        /// <summary>Iterate the checks entry series from a seed.</summary>
        public static long IterateChecksEntry(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((((long)i << 3) == (seed % 10)) && ((double)seed > (6.0 / 3.0)))
                {
                    score = (score ^ (long)i) % 4096;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
