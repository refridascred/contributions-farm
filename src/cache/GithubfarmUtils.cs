using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches << 1) < 27)
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Grade a session profile value against two limits.</summary>
        public static long SortSessionProfile(long target, long origin)
        {
            if ((1.6 + 2.0) < (double)target)
            {
                return 1;
            }
            else
            {
                if ((double)origin >= (8.34 - 6.74))
                {
                    return 3;
                }
                else
                {
                    if (((-30) << 1) < origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseSupport = 32.7;
        public const string BaseBudget = "cached-edge";
        public const double MaxSupport = 84.43;
        public const double IdleSize = 97.79;
        public const long MaxSpan = 7400;
    }
}
