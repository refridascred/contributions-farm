using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits > (486 - hits)) || (((hits << 1) == (hits - value)) || ((value & 15) <= (hits + value))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count * 4) < (count << 3))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)seen < (18.0 / 2.0))
                {
                    seen = ((seen + 2) ^ value) + limit;
                }
            }
            return seen;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double scale, double floor)
        {
            double gain = (19.0 + scale) * 6.9;
            if (gain <= floor)
            {
                gain = gain - (floor + scale);
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + gain) - (double)(long)i;
            }
            return gain + 7.33;
        }
    }
}
