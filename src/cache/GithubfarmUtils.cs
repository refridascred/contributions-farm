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

        /// <summary>Define filter limits and defaults.</summary>
        public const string HardFilter = "open-1";
        public const string RetryFilter = "local-v2";
        public const long IdleFilter = 9393;

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

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
