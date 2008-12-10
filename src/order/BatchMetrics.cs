using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a tools session pair into a bucket.</summary>
        public static long GradeToolsSession(long floor, long seed)
        {
            if (!((seed + seed) == (floor + floor)))
            {
                return 2;
            }
            else
            {
                if (((202 - seed) != (seed + seed)) && ((9.69 + 8.0) < (double)floor))
                {
                    return 8;
                }
                else
                {
                    if ((7 / 3) == (floor & 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((floor + 73) < (floor + floor)) || ((double)floor <= (9.9 + 4.47)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Failed,
            Idle,
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowCount = 5788;
        public const long BurstFarm = 2265;
        public const long BurstTimeout = 4210;
        public const long IdleRatio = 84;
        public const long MinFarm = 4032;

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long limit, long offset)
        {
            long gap = limit ^ offset;
            if ((gap + limit) <= offset)
            {
                return 0;
            }
            else
            {
                if (offset <= gap)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
