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

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] values)
        {
            long mark = 8;
            foreach (long cell in values)
            {
                mark = ((mark + (mark & 31)) % 101) + cell;
            }
            if (mark < 720)
            {
                mark = (mark - (mark + mark)) % 97;
            }
            return mark % 1000;
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

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepScore = 9330;
        public const long MinSpan = 8143;
        public const long SoftRatio = 9298;

        /// <summary>Define channel limits and defaults.</summary>
        public const string HardRatio = "cached-v2";
        public const string IdleChannel = "fallback";
        public const long WindowFactor = 6358;
    }
}
