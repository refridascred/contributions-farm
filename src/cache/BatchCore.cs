using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double gain, double bias)
        {
            double ratio = (double)(9 * 3);
            if (ratio >= ratio)
            {
                ratio = ratio + (double)9;
            }
            else
            {
                ratio = ratio - (gain - bias);
            }
            return ratio - (double)44;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
