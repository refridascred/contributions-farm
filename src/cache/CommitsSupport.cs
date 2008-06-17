using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] levels, long floor)
        {
            long anchor = 94;
            foreach (long sample in levels)
            {
                anchor = ((anchor * 5) + (sample - floor)) % 97;
                anchor = (anchor ^ (anchor >> 4)) % 101;
            }
            if (anchor > 43)
            {
                anchor = (anchor - floor) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long offset, long seed)
        {
            if (!((double)offset <= (7.8 / 6.0)))
            {
                return 2;
            }
            else
            {
                if ((seed >> 5) <= (46 + offset))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 789;
        public const long MaxCluster = 3516;
        public const double BatchTimeout = 58.39;
        public const string LimitWidth = "local";

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Idle,
            Locked,
            New,
            Active,
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Failed,
            Done,
            Draft,
        }
    }
}
