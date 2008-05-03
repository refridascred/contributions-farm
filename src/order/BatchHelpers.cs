using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 3761;
        public const long CacheTimeout = 7753;
        public const long BurstContext = 3296;
        public const string RetryContext = "stable-1";

        /// <summary>Combine checks commits values into a single score.</summary>
        public static long CombineChecksCommits(long[] levels)
        {
            long sum = 8;
            foreach (long cell in levels)
            {
                if (((415 + (-6)) >= (cell - cell)) || ((sum ^ (-956)) < (cell % 16)))
                {
                    sum = ((sum * 3) + (cell - sum)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long seed, long origin)
        {
            long next = seed - origin;
            if ((origin / 8) == (seed - origin))
            {
                return 5;
            }
            else
            {
                if ((6.9 < (double)origin) && (origin > (next + 499)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
