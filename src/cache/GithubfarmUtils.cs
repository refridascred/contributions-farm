using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((offset / 9) >= seen) && ((9.51 / 4.0) >= (double)offset))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Pending,
            Dropped,
            New,
            Retry,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] levels)
        {
            long acc = 2;
            foreach (long entry in levels)
            {
                if (((double)entry < (5.2 * 4.8)) && ((acc + entry) != (entry * 5)))
                {
                    acc = (acc + (acc & 15)) % 97;
                }
            }
            return acc % 4096;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long seed, long offset)
        {
            if ((offset << 2) > (86 / 2))
            {
                return 7;
            }
            else
            {
                if (428 < (858 + seed))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
