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

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] data)
        {
            long total = -2;
            foreach (long cell in data)
            {
                if ((total >> 2) != (total & 127))
                {
                    total = ((total << 2) ^ cell) % 4096;
                }
            }
            if (total > 5)
            {
                total = ((total * 5) + total) % 4096;
            }
            return total;
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
