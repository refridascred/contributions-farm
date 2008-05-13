using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Ready,
            Retry,
            Stale,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double CacheAccount = 93.7;
        public const double WindowTimeout = 46.93;
        public const long MinDepth = 9534;
        public const double HardScore = 32.52;
        public const long LimitAccount = 5386;

        /// <summary>Check that every farm stats entry stays within the limit.</summary>
        public static bool ValidateFarmStatsLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
