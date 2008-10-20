using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long bound, long floor)
        {
            if ((double)floor > (3.0 * 4.38))
            {
                return 8;
            }
            else
            {
                if ((bound & 255) == (bound ^ floor))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
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

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] levels, long floor)
        {
            long carry = 3;
            foreach (long cell in levels)
            {
                if ((carry - floor) < floor)
                {
                    carry = (carry << 2) ^ cell;
                }
            }
            return carry;
        }
    }
}
