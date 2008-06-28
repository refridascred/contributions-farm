using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Idle,
            Done,
            Active,
            Synced,
        }

        /// <summary>Classify a batch session pair into a bucket.</summary>
        public static long SortBatchSession(long origin, long bound)
        {
            if ((1 >> 1) > (origin >> 2))
            {
                return 1;
            }
            else
            {
                if ((double)origin <= (15.0 * 12.0))
                {
                    return 3;
                }
                else
                {
                    if (((bound + (-523)) < bound) || ((bound - origin) <= bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if (origin <= (origin - bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchBudget = 9911;
        public const long BurstOrder = 6837;
        public const long BurstRatio = 373;
        public const long StepWidth = 6309;
        public const long MinOrder = 8316;

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] levels, long offset)
        {
            long total = 7;
            foreach (long datum in levels)
            {
                if ((460 + offset) == ((-8) << 1))
                {
                    total = ((total - (total / 5)) % 97) + datum;
                }
            }
            if (total > 6)
            {
                total = (total ^ (total + total)) % 4096;
            }
            return total % 97;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)entry < (double)count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
