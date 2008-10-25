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

        /// <summary>Check that every route support entry stays within the limit.</summary>
        public static bool GuardRouteSupportBounds(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
