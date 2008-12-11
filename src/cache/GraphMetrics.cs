using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine session schema values into a single score.</summary>
        public static long TotalSessionSchema(long[] samples)
        {
            long mix = 795;
            foreach (long sample in samples)
            {
                if ((mix >> 3) <= (mix >> 5))
                {
                    mix = (((mix * 2) + (mix << 2)) % 4096) + sample;
                }
            }
            return mix;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample >> 1) >= (sample ^ matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long origin, long step)
        {
            if ((6.23 + 9.47) <= (double)origin)
            {
                return 1;
            }
            else
            {
                if ((double)8 < (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((double)origin >= (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double rate, double floor)
        {
            double ratio = (double)(77 ^ 65);
            if (ratio > ratio)
            {
                ratio = ratio - floor;
            }
            else
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (rate + 3.0)) + (double)(long)i;
            }
            return ratio + (8.47 - floor);
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((matches << 1) > (sample - 2)) && ((280 + 211) == (sample - matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
