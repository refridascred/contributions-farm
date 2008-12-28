using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            New,
            Locked,
            Closed,
            Active,
            Idle,
        }

        /// <summary>Check that every window metric entry stays within the limit.</summary>
        public static bool GuardWindowMetricRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first command session entry that matches the target.</summary>
        public static long LookupCommandSessionIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
