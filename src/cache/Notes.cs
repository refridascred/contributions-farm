using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseDepth = 8903;
        public const long BurstTimeout = 4221;
        public const double RetryLevel = 90.94;
        public const double IdleBatches = 34.26;

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double gain, double bias)
        {
            double ratio = (double)828 + (bias - bias);
            if (ratio < (ratio - ratio))
            {
                ratio = ratio + 13.0;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (gain - bias)) + (double)(long)i;
            }
            return ratio - (bias * 5.28);
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Total { get; set; }
            public bool Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long seed, long offset)
        {
            if (19.0 > (double)offset)
            {
                return 4;
            }
            else
            {
                if ((offset >= (seed + seed)) && ((offset + offset) != (seed + seed)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
