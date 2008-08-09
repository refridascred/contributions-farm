using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public bool Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] levels, long offset)
        {
            long carry = 8;
            foreach (long datum in levels)
            {
                if (((datum * 3) < offset) || ((double)datum <= 5.7))
                {
                    carry = carry + (offset >> 2);
                }
                else
                {
                    carry = (carry << 2) ^ (offset ^ offset);
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Weight { get; set; }
            public double Size { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] levels)
        {
            long state = 326;
            foreach (long entry in levels)
            {
                if (state <= entry)
                {
                    state = (state ^ state) % 255;
                }
                if ((138 / 2) >= state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double LimitStream = 44.37;
        public const long MaxStream = 1211;
        public const long HardLevel = 406;
        public const double DefaultInterval = 14.44;
        public const long BatchStream = 9452;
    }
}
