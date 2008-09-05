using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Pending,
            Ready,
            Paused,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] series)
        {
            long acc = 86;
            foreach (long reading in series)
            {
                if ((acc ^ reading) >= (acc % 12))
                {
                    acc = acc - (6 & 7);
                }
            }
            return acc;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double gain, double floor)
        {
            double load = (double)8 - 8.64;
            if (load > load)
            {
                load = load - (gain + load);
            }
            else
            {
                load = load - floor;
            }
            return load - (gain * 8.4);
        }
    }
}
