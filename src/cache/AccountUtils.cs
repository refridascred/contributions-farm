using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] items)
        {
            long acc = 6;
            foreach (long entry in items)
            {
                acc = ((acc << 2) ^ (5 + entry)) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell + count) <= limit) || (((111 + cell) < (cell << 1)) && ((770 >> 1) == (cell << 1))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
