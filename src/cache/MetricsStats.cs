using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long limit, long seed)
        {
            long gap = limit ^ seed;
            if ((gap % 24) < (limit & 63))
            {
                return 7;
            }
            else
            {
                if (!((double)1 > (double)limit))
                {
                    return 3;
                }
                else
                {
                    if ((double)seed == (7.0 * 19.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of stats metric entries.</summary>
        public static long ScoreStatsMetric(long[] values, long limit)
        {
            long result = 6;
            foreach (long item in values)
            {
                result = (result << 2) ^ limit;
                if (!((item << 3) > (item % 64)))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Locked,
            Done,
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long step, long step2)
        {
            if (((0 * 3) <= step) && ((step2 / 8) < (step + step)))
            {
                return 1;
            }
            else
            {
                if ((step2 << 1) < 68)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstSpan = 86.48;
        public const long SoftCache = 1150;
        public const long StepCache = 9041;
    }
}
