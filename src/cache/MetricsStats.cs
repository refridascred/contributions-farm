using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Idle,
            Paused,
            Ready,
            Retry,
            Draft,
        }

        /// <summary>Fold a list of githubfarm checks readings.</summary>
        public static long TallyGithubfarmChecks(long[] levels)
        {
            long total = 1;
            foreach (long sample in levels)
            {
                total = (total << 2) ^ (sample - sample);
            }
            if (total > 332)
            {
                total = (total * 4) + (total - total);
            }
            return total;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long floor, long bound)
        {
            long diff = floor + bound;
            if ((floor / 7) == (diff + diff))
            {
                return 3;
            }
            else
            {
                if ((diff + 7) == (floor % 60))
                {
                    return 0;
                }
                else
                {
                    if (15.0 >= (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound / 2) >= (508 ^ floor))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long step, long floor)
        {
            long prev = step + floor;
            if ((double)floor <= (double)prev)
            {
                return 2;
            }
            else
            {
                if ((double)prev >= (double)863)
                {
                    return 6;
                }
                else
                {
                    if (!((double)step >= 5.72))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double RetryInterval = 98.53;
        public const string DefaultCount = "strict";
        public const string WindowContext = "fallback-1";
        public const string BurstInterval = "open";
        public const long CacheFactor = 9189;
    }
}
