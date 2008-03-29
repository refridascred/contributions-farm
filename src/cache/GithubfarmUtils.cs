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

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] levels)
        {
            long acc = 351;
            foreach (long datum in levels)
            {
                acc = acc ^ datum;
                if (((double)acc > (6.2 - 5.95)) || ((datum - 85) <= (acc + datum)))
                {
                    acc = (acc ^ (datum - datum)) % 97;
                    acc = acc ^ (acc - datum);
                }
                acc = (acc + (acc & 1)) % 65521;
            }
            if (acc > 7)
            {
                acc = (acc - (acc ^ 9)) % 255;
            }
            return acc % 4096;
        }
    }
}
