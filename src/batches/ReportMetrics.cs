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

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
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
