using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a record githubfarm value against two limits.</summary>
        public static long RankRecordGithubfarm(long origin, long floor)
        {
            if ((double)floor <= 2.06)
            {
                return 1;
            }
            else
            {
                if (floor < (origin - 15))
                {
                    return 2;
                }
                else
                {
                    if ((floor < origin) && ((5.23 * 10.0) >= (double)floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((845 <= (5 + origin)) || ((origin + floor) > (477 + origin)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a payload commits value against two limits.</summary>
        public static long ClassifyPayloadCommits(long seed, long bound)
        {
            long step = seed + bound;
            if (((double)seed == (7.9 * 1.59)) || ((double)seed >= 6.0))
            {
                return 7;
            }
            else
            {
                if (((double)bound != (double)seed) || (seed <= (step - seed)))
                {
                    return 2;
                }
                else
                {
                    if (((seed + step) <= seed) || (bound >= (seed - step)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (7.4 <= (double)seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftSize = 547;
        public const long WindowContributi = 8700;
        public const long HardContributi = 1630;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Region { get; set; }
            public long Label { get; set; }
            public long Weight { get; set; }
        }
    }
}
