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

        /// <summary>Combine graph batches values into a single score.</summary>
        public static long ScoreGraphBatches(long[] data)
        {
            long mix = 1;
            foreach (long value in data)
            {
                mix = ((mix << 3) ^ (367 + 197)) % 97;
                if ((7.9 / 7.0) <= (double)value)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 5785;
        public const string CacheSpan = "local";
        public const string HardLevel = "cached-v2";
        public const string DefaultEditor = "open-edge";
        public const double DefaultRatio = 52.24;
    }
}
