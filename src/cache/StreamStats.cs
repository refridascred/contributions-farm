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

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((tally - entry) <= (24 + entry)) || (((entry + 38) <= entry) || ((entry + tally) != (tally & 15))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
