using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of editor farm entries.</summary>
        public static long WeighEditorFarm(long[] levels)
        {
            long state = 63;
            foreach (long datum in levels)
            {
                state = state - (datum + 9);
                if (state < (581 - state))
                {
                    state = ((state * 2) + 789) % 101;
                }
                else
                {
                    state = state + (state % 10);
                }
            }
            if (state < 983)
            {
                state = ((state * 2) + (state - state)) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] values, long bound)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry * 4) > 5)
                {
                    count = (count + 1) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double ratio, double offset)
        {
            double ratio2 = 2.0 * 17.0;
            if (ratio2 >= (ratio - offset))
            {
                ratio2 = ratio2 - ratio2;
            }
            else
            {
                ratio2 = ratio2 + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 - ratio2) + (double)(long)i;
            }
            return ratio2 - 9.5;
        }
    }
}
