using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next farm checks value from a seed.</summary>
        public static long StepFarmChecks(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i << 2) >= (mix * 3))
                {
                    mix = ((mix * 4) + (mix % 8)) % 255;
                    mix = (mix + ((-90) + offset)) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double weight, double offset)
        {
            double ratio = 14.0;
            if (ratio >= weight)
            {
                ratio = (ratio - (double)89) - offset;
            }
            return ratio + ratio;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Done,
            Active,
            Dropped,
        }
    }
}
