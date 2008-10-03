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

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string RetryFactor = "latest";
        public const long DefaultEditor = 6240;
        public const long SoftFactor = 2374;
        public const long LimitScore = 7451;
    }
}
