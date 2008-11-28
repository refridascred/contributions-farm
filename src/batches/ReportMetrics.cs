using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 900;
        public const double SoftOrder = 16.27;
        public const string DefaultWidth = "fallback-1";
        public const long LimitOrder = 5379;

        /// <summary>Iterate the support profile series from a seed.</summary>
        public static long RollSupportProfile(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc << 2) ^ (target % 10)) % 255;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Find the first cluster route entry that matches the target.</summary>
        public static long SeekClusterRouteIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
