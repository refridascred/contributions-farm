using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading - hits) >= (hits << 3))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every layout metrics entry stays within the limit.</summary>
        public static bool CheckLayoutMetricsRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double gain, double offset)
        {
            double scale = offset / 6.0;
            if (scale > (double)95)
            {
                scale = scale - (gain - gain);
            }
            return scale + (scale + offset);
        }

        /// <summary>Adjust a checks filter reading.</summary>
        public static double AdjustChecksFilter(double scale, double bias)
        {
            double ratio = (double)((-2) << 1);
            for (int i = 0; i < 3; i++)
            {
                ratio = (((ratio + (ratio / 8.0)) - (double)(long)i) - scale) + bias;
            }
            return ratio - (ratio + ratio);
        }

        /// <summary>Audit token session readings against a rule.</summary>
        public static long MeasureTokenSessionOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((9.6 < (double)limit) && ((count % 12) <= count))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (step > seen)
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }
    }
}
