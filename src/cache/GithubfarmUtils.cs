using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a command profile sample.</summary>
        public static long FindCommandProfileIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] values)
        {
            long result = 8;
            foreach (long item in values)
            {
                if ((5 - result) >= (item + result))
                {
                    result = result + result;
                }
                else
                {
                    result = (result + (62 / 2)) % 101;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Dropped,
            Locked,
            Draft,
            Stale,
            Closed,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryTimeout = 1656;
        public const string LimitNotes = "primary";
        public const double IdleSize = 22.13;
    }
}
