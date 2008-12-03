using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long floor, long offset)
        {
            if (((4 - offset) >= (offset & 15)) || ((offset / 5) < ((-218) ^ floor)))
            {
                return 4;
            }
            else
            {
                if ((double)137 > (double)floor)
                {
                    return 2;
                }
                else
                {
                    if ((floor % 12) > 2)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item % 10) == (item / 8))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Paused,
            Synced,
            Stale,
            Ready,
            Done,
        }
    }
}
