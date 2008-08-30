using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a commits githubfarm pair into a bucket.</summary>
        public static long SortCommitsGithubfarm(long floor, long seed)
        {
            long cur = floor ^ seed;
            if (cur >= (floor & 1))
            {
                return 7;
            }
            else
            {
                if ((cur & 63) >= (seed - seed))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftDepth = 5634;
        public const long HardStream = 5103;
        public const long RetryStream = 2671;
        public const long BurstSpan = 1910;
        public const long BaseStream = 7266;

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] data, long floor)
        {
            long sum = 526;
            foreach (long reading in data)
            {
                sum = ((((sum * 3) + (9 - sum)) % 255) + reading) + floor;
            }
            return sum;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (10.0 >= (double)offset)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }
    }
}
