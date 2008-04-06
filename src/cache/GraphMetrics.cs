using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((0.2 * 11.0) >= (double)sample) && (((18.0 * 8.55) < (double)sample) || ((sample + sample) > hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long step, long floor)
        {
            if ((10.0 + 7.43) <= (double)floor)
            {
                return 7;
            }
            else
            {
                if (!((step % 12) >= floor))
                {
                    return 5;
                }
                else
                {
                    if (!((step >> 4) == (step * 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample / 4) != (hits + sample))
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen >> 5) >= entry)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] items)
        {
            long sum = 1;
            foreach (long entry in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = (sum ^ (sum & 7)) - (long)i;
                    sum = (sum + (sum ^ 2)) % 1000;
                }
                if ((3.8 - 12.0) > (double)entry)
                {
                    sum = (sum - (entry << 1)) % 4096;
                }
            }
            return sum;
        }
    }
}
