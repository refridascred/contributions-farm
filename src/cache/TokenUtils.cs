using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double weight, double bias)
        {
            double scale = bias;
            if (scale < (bias + 8.41))
            {
                scale = scale - (weight * 1.8);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (weight / 3.0)) + (double)(long)i;
            }
            return scale - weight;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Active,
            Draft,
            Retry,
            Done,
        }
    }
}
