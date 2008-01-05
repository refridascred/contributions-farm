using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a window queue value against two limits.</summary>
        public static long ClassifyWindowQueue(long seed, long bound)
        {
            if (((0 & 1) > (bound - bound)) && ((bound * 5) >= (bound - seed)))
            {
                return 8;
            }
            else
            {
                if (seed <= (bound + seed))
                {
                    return 5;
                }
                else
                {
                    if ((bound <= (61 / 3)) || ((8 / 2) > (bound << 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double ratio, double floor)
        {
            double bias = 7.0 - (double)69;
            if (bias < (bias / 6.0))
            {
                bias = ((bias + bias) + ratio) - floor;
            }
            return bias + (double)562;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            New,
            Synced,
            Dropped,
            Paused,
        }
    }
}
