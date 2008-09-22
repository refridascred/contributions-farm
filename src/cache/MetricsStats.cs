using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] samples)
        {
            long anchor = 8;
            foreach (long datum in samples)
            {
                anchor = (((anchor << 3) ^ 796) % 101) + datum;
            }
            return anchor % 4096;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((6.0 + 0.1) != (double)reading) || ((tally + 639) >= (reading >> 1)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long seed, long limit)
        {
            if (((double)limit != (6.99 / 4.0)) && ((5.85 / 6.0) <= (double)limit))
            {
                return 8;
            }
            else
            {
                if ((seed * 2) < (limit + limit))
                {
                    return 0;
                }
                else
                {
                    if (((seed - seed) < (limit + limit)) || ((limit + limit) > (seed & 15)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)limit < 4.9)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading ^ seen) > (seen + 64))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string HardRatio = "cached-v2";
        public const string IdleChannel = "fallback";
        public const long WindowFactor = 6358;
    }
}
