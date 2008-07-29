using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Locked,
            Closed,
            Failed,
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

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long origin, long floor)
        {
            if ((double)floor >= (2.0 * 0.3))
            {
                return 7;
            }
            else
            {
                if ((origin % 10) == (floor << 2))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((5 % 5) == (entry - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
