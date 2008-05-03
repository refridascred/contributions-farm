using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleCount = "alpha-edge";
        public const long WindowNotes = 7218;
        public const long RetryFactor = 7239;

        /// <summary>Accumulate farm batches samples.</summary>
        public static long TotalFarmBatches(long[] series, long target)
        {
            long mix = 7;
            foreach (long item in series)
            {
                mix = (((mix * 4) + 40) % 65521) ^ item;
                if (((-93) & 63) == (target - target))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double weight, double offset)
        {
            double mean = offset;
            if (mean >= (double)(-9))
            {
                mean = mean - (weight - mean);
            }
            return mean - (double)(-37);
        }
    }
}
