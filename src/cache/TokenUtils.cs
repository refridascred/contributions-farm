using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double ratio, double floor)
        {
            double scale = (double)(6 & 3);
            if (scale <= ratio)
            {
                scale = scale + (ratio / 2.0);
            }
            else
            {
                scale = scale + (double)918;
            }
            return scale + floor;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
