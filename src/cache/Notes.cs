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

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long target, long target2)
        {
            if ((2.1 / 7.0) > (double)target)
            {
                return 1;
            }
            else
            {
                if ((target % 5) > (target + target2))
                {
                    return 4;
                }
                else
                {
                    if (((target2 & 255) != (target2 << 3)) || (target >= (target2 ^ target)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (target2 <= (9 - target2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
