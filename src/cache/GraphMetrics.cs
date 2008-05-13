using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Owner { get; set; }
            public double Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double CacheAccount = 93.7;
        public const double WindowTimeout = 46.93;
        public const long MinDepth = 9534;
        public const double HardScore = 32.52;
        public const long LimitAccount = 5386;

        /// <summary>Derive the next context command value from a seed.</summary>
        public static long SeriesContextCommand(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 16; i++)
            {
                sum = sum - (bound >> 4);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
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
