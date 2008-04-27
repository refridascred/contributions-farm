using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 2039;
        public const double MaxStream = 93.8;
        public const long StepStream = 9304;
        public const long SoftBudget = 6903;
        public const double MinStream = 22.28;

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] items, long offset)
        {
            long mix = 0;
            foreach (long datum in items)
            {
                if (((mix << 3) != (mix % 16)) && ((7.22 + 3.75) > (double)offset))
                {
                    mix = (((mix << 3) ^ offset) % 101) + datum;
                }
            }
            if (mix < 3)
            {
                mix = ((mix << 3) ^ mix) % 101;
            }
            return mix;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double scale, double floor)
        {
            double mean = (double)(517 - 452);
            if (mean < (double)901)
            {
                mean = (mean - 1.72) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - (scale * 6.0);
        }
    }
}
