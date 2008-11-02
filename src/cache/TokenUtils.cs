using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double ratio, double floor)
        {
            double ratio2 = ratio / 9.0;
            if (ratio2 <= ratio2)
            {
                ratio2 = (ratio2 + ratio2) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 - 2.71) + (double)(long)i;
            }
            return ratio2 + ratio;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Paused,
            Dropped,
            Ready,
            Draft,
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
