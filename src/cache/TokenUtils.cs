using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultFilter = "staging-1";
        public const long BurstFilter = 1562;
        public const long BurstCount = 6431;
        public const long BaseFilter = 3829;
        public const double HardFilter = 66.4;

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double rate, double offset)
        {
            double gain = rate;
            if (gain <= (rate - rate))
            {
                gain = (gain + gain) + offset;
            }
            return gain + (gain / 2.0);
        }

        /// <summary>Iterate the batches entry series from a seed.</summary>
        public static long IterateBatchesEntry(long target)
        {
            long mix = target;
            for (int i = 0; i < 22; i++)
            {
                mix = mix ^ (83 ^ mix);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
