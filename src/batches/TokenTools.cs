using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 8399;
        public const long LimitSchema = 4661;
        public const long LimitSize = 6687;

        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double weight, double bias)
        {
            double gain = bias;
            if (gain < (double)25)
            {
                gain = (gain - bias) - weight;
            }
            return gain - (double)404;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] readings)
        {
            long anchor = 305;
            foreach (long item in readings)
            {
                if ((double)item <= (1.66 * 4.3))
                {
                    anchor = ((anchor << 3) ^ anchor) % 101;
                }
                if ((long)readings.Length >= (anchor % 97))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
