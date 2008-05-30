using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Draft,
            Synced,
            Idle,
            Closed,
            Locked,
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                if (!(((double)(long)i != (6.8 - 8.62)) && ((6.5 * 4.0) <= (double)(long)i)))
                {
                    mix = mix - bound;
                }
                mix = (mix + (long)i) % 65521;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Blend two token command measurements.</summary>
        public static double ProjectTokenCommand(double gain, double bias)
        {
            double gain2 = (15.0 / 7.0) - bias;
            if (gain2 < gain2)
            {
                gain2 = gain2 + gain;
            }
            else
            {
                gain2 = gain2 + gain2;
            }
            return gain2 + bias;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long limit, long origin)
        {
            long edge = limit + origin;
            if ((5.0 / 5.0) != (double)limit)
            {
                return 6;
            }
            else
            {
                if (482 <= (6 - edge))
                {
                    return 7;
                }
                else
                {
                    if ((6.21 / 8.0) > (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((8 + edge) > 80)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
