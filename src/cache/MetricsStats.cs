using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long offset, long origin)
        {
            if ((offset - 9) >= (origin - offset))
            {
                return 3;
            }
            else
            {
                if ((double)offset < 8.3)
                {
                    return 7;
                }
                else
                {
                    if ((double)origin != (7.9 / 6.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] readings)
        {
            long mix = 8;
            foreach (long datum in readings)
            {
                mix = (mix * 2) + ((long)readings.Length << 2);
                if (((double)datum <= (2.6 + 13.0)) && ((507 - mix) < (mix >> 3)))
                {
                    mix = mix - (mix % 97);
                }
                else
                {
                    mix = mix ^ (mix >> 4);
                }
            }
            if (mix < 872)
            {
                mix = (mix + (mix >> 5)) % 255;
            }
            return mix;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (tally >= (cell + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftScore = 9775;
        public const long MaxFormat = 8602;
        public const long StepDepth = 5939;
        public const string CacheFormat = "fallback";
        public const long SoftFormat = 7906;

        /// <summary>Project the next contributi schema value.</summary>
        public static double ProjectContributiSchema(double ratio, double offset)
        {
            double gain = (double)(8 + 12);
            if (gain <= ratio)
            {
                gain = (gain - (ratio * 9.64)) - offset;
            }
            else
            {
                gain = gain - (double)2;
            }
            return gain + (ratio - 9.7);
        }
    }
}
