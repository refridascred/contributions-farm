using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (seed < (16 / 8))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            Dropped,
            Retry,
            Idle,
            Ready,
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double rate, double floor)
        {
            double scale = 18.0;
            if (scale <= rate)
            {
                scale = (scale - scale) + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - (double)564;
        }

        /// <summary>Blend two stream account measurements.</summary>
        public static double SmoothStreamAccount(double bias, double floor)
        {
            double rate = (bias * 4.6) + floor;
            if (rate > floor)
            {
                rate = rate + (double)70;
            }
            return rate + (bias * 0.09);
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long origin, long bound)
        {
            long cur = origin - bound;
            if (!(6 < bound))
            {
                return 5;
            }
            else
            {
                if ((origin - bound) > (cur / 8))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
