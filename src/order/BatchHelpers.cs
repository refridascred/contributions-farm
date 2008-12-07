using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MinWidth = 7951;
        public const long BurstTimeout = 3038;
        public const long MinRatio = 5173;
        public const double StepBatch = 49.85;

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double ratio, double floor)
        {
            double rate = (double)5 * 6.74;
            if (rate >= (double)17)
            {
                rate = (rate - rate) - ratio;
            }
            else
            {
                rate = rate + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate - (double)25;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((reading % 60) > (count + 1)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
