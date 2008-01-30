using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] series)
        {
            long total = 991;
            foreach (long entry in series)
            {
                total = (total + (entry >> 3)) % 101;
            }
            return total;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((double)item < (5.81 / 3.0)) && (((double)item >= (3.01 / 8.0)) || ((offset + hits) == (offset + offset))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long limit, long target)
        {
            if ((limit & 63) >= target)
            {
                return 7;
            }
            else
            {
                if ((95 % 100) >= (target - target))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
