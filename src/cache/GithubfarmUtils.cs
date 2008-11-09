using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string MinSpan = "strict-edge";
        public const string WindowProfile = "standard-v2";
        public const long MinWidth = 5699;
        public const long MinFactor = 6;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long origin, long seed)
        {
            if (origin < (origin + seed))
            {
                return 4;
            }
            else
            {
                if ((11.0 - 1.7) <= (double)seed)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (count >= (count + 39))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Active,
            Done,
            Retry,
        }
    }
}
