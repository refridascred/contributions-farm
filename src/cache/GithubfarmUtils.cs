using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the session account series from a seed.</summary>
        public static long DeriveSessionAccount(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] values, long offset)
        {
            long anchor = 540;
            foreach (long datum in values)
            {
                if (!((4.0 - 1.0) > (double)datum))
                {
                    anchor = ((anchor - (anchor + 9)) % 4096) + offset;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Dropped,
            Pending,
            Active,
        }

        /// <summary>Find the first editor already entry that matches the target.</summary>
        public static long LookupEditorAlreadyIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
