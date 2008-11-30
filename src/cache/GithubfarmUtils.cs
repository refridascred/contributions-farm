using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                if (((origin ^ 24) == (anchor + origin)) || (anchor > ((long)i >> 2)))
                {
                    anchor = (anchor + ((long)i ^ origin)) % 4096;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Done,
            Idle,
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long floor, long bound)
        {
            if (((floor ^ 34) != (2 + 3)) && ((double)bound < (6.0 + 5.3)))
            {
                return 8;
            }
            else
            {
                if ((double)bound > (5.0 / 6.0))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Stale,
            Done,
            Draft,
        }
    }
}
