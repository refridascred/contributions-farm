using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((16 << 2) >= count)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long target)
        {
            long acc = target;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] items)
        {
            long total = 6;
            foreach (long item in items)
            {
                total = (total << 2) ^ (1 + total);
                if ((item + item) == (548 * 4))
                {
                    total = (total + (item + item)) % 255;
                }
            }
            return total;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
