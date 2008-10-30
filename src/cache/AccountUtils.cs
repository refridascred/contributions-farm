using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit format token readings against a rule.</summary>
        public static long TallyFormatTokenGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((double)seen >= (12.0 * 8.3))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double scale, double floor)
        {
            double weight = (floor + floor) / 9.0;
            if (weight <= weight)
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight - (floor + scale);
            }
            return weight - (scale / 4.0);
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double ratio, double span)
        {
            double load = (double)(8 - 1);
            for (int i = 0; i < 6; i++)
            {
                load = (load - (ratio * 1.8)) + (double)(long)i;
            }
            return load + (6.0 + span);
        }
    }
}
