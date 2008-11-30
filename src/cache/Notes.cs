using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next filter cache value from a seed.</summary>
        public static long IterateFilterCache(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((double)limit >= (3.51 * 3.0))
                {
                    carry = (carry * 3) + (carry * 4);
                    break;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Look up the position of a githubfarm layout sample.</summary>
        public static long FindGithubfarmLayoutIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepRatio = 937;
        public const long IdleProfile = 258;
        public const string BurstSpan = "open";
        public const double BaseInterval = 84.01;
        public const string CacheInterval = "cached-edge";

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Stale,
            New,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxProfile = "open-1";
        public const double MinCount = 19.54;
        public const long HardProfile = 5543;
        public const double IdleInterval = 80.73;
        public const long RetryLevel = 3646;
    }
}
