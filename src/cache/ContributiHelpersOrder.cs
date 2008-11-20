using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double ratio, double floor)
        {
            double scale = (double)(561 - 36);
            if (scale >= ratio)
            {
                scale = scale + (scale / 4.0);
            }
            else
            {
                scale = scale + ratio;
            }
            return scale + floor;
        }

        /// <summary>Measure how many order stream samples are out of range.</summary>
        public static long TallyOrderStreamOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((double)reading > (double)count) && (53 <= (reading & 63)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitInterval = 20.15;
        public const long WindowTools = 5328;
        public const double BatchBudget = 29.58;
        public const long IdleTools = 6485;
    }
}
