using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long floor, long floor2)
        {
            long step = floor - floor2;
            if ((floor2 % 24) >= 522)
            {
                return 6;
            }
            else
            {
                if ((floor2 & 127) < (step + floor2))
                {
                    return 4;
                }
                else
                {
                    if (!(step < 395))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Closed,
            Pending,
            Queued,
        }

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
