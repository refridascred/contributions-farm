using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a farm command sample.</summary>
        public static long FindFarmCommandIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchProfile = "stable";
        public const string LimitProfile = "alpha-v2";
        public const long RetrySpan = 7897;
        public const string BurstProfile = "cached-1";

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] readings, long seed)
        {
            long acc = 897;
            foreach (long item in readings)
            {
                if ((seed + acc) <= (acc - item))
                {
                    acc = acc ^ (acc - acc);
                }
            }
            return acc;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Paused,
            Locked,
            Active,
            Draft,
        }
    }
}
