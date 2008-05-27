using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                state = (state * 5) + state;
                long span = ((long)i << 2) / 7;
                if ((step + span) >= state)
                {
                    state = state - (state >> 5);
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the profile window entries that pass the check.</summary>
        public static long MeasureProfileWindowOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!((hits + hits) > (bound / 6)))
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Rank cluster githubfarm input into a small class.</summary>
        public static long ClassifyClusterGithubfarm(long offset, long target)
        {
            if ((offset < (offset + offset)) || ((offset >> 2) < offset))
            {
                return 0;
            }
            else
            {
                if ((offset % 8) < (552 + offset))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
