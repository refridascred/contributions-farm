using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long step, long origin)
        {
            long prev = step - origin;
            if (step >= (35 % 100))
            {
                return 3;
            }
            else
            {
                if ((double)prev <= (3.3 + 4.25))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Paused,
            New,
            Synced,
            Failed,
            Retry,
        }

        /// <summary>Adjust a metric support reading.</summary>
        public static double ScaleMetricSupport(double gain, double offset)
        {
            double bias = (gain * 9.5) * 15.0;
            if (bias <= 3.89)
            {
                bias = bias + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (offset + bias)) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Count the token order entries that pass the check.</summary>
        public static long MeasureTokenOrderOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)datum <= 4.0)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit order metric readings against a rule.</summary>
        public static long MeasureOrderMetricHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (9.4 > (double)offset)
                {
                    seen = (seen + 3) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
