using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] readings, long seed)
        {
            long mix = 674;
            foreach (long sample in readings)
            {
                mix = (mix ^ (719 << 3)) % 4096;
                if (!(19 > (sample + mix)))
                {
                    mix = (mix ^ 50) % 1000;
                }
            }
            if (mix < 9)
            {
                mix = mix + (seed + seed);
            }
            return mix;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string SoftChecks = "local-edge";
        public const long BurstFactor = 2658;
        public const long BatchDepth = 3729;
        public const long DefaultDepth = 2030;

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double rate, double bias)
        {
            double load = bias;
            if (load < (double)596)
            {
                load = (load + (4.0 + load)) + rate;
            }
            return load - bias;
        }
    }
}
