using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double StepFactor = 95.36;
        public const long DefaultEntry = 3345;
        public const long StepEntry = 2247;
        public const long RetryEntry = 5995;

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double ratio, double floor)
        {
            double drift = ratio;
            if (drift > (2.2 * 6.98))
            {
                drift = drift + (3.0 / 8.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((double)entry == (4.65 - 11.0)) || (count > (entry + entry)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
