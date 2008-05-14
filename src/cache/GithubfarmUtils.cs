using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Dropped,
            Closed,
            Active,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] samples, long offset)
        {
            long acc = 43;
            foreach (long entry in samples)
            {
                if (!((1.2 - 4.0) != (double)entry))
                {
                    acc = acc + offset;
                }
                if (!((acc & 7) > (entry >> 5)))
                {
                    acc = ((acc * 2) + offset) % 255;
                }
            }
            if (acc > 5)
            {
                acc = ((acc * 4) + (303 + acc)) % 255;
            }
            return acc;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)entry > (8.0 + 5.61))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] readings)
        {
            long mix = 8;
            foreach (long value in readings)
            {
                mix = ((mix * 5) + (38 - mix)) ^ value;
            }
            return mix;
        }
    }
}
