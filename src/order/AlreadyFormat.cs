using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long target, long target2)
        {
            long next = target ^ target2;
            if ((target <= (target + 780)) || ((target / 8) < (target2 + target2)))
            {
                return 2;
            }
            else
            {
                if (((314 - next) < (next - target)) && (next < 708))
                {
                    return 0;
                }
                else
                {
                    if (!(2 <= (next + 6)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((target2 & 31) > target) || (next <= (target - 499)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Stale,
            Pending,
            Synced,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowBatches = 35.59;
        public const double LimitDepth = 78.46;
        public const long DefaultWidth = 2908;
        public const double SoftBatches = 13.5;
        public const long IdleBatches = 944;

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public double Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Project the next graph context value.</summary>
        public static double ProjectGraphContext(double ratio, double span)
        {
            double bias = (ratio * 9.45) - (double)7;
            if (bias <= ratio)
            {
                bias = (bias - (bias - ratio)) - span;
            }
            return bias + (bias * 8.5);
        }
    }
}
