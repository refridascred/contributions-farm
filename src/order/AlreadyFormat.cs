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

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 495;
        public const long MaxLevel = 3766;
        public const double StepRecord = 44.48;
        public const string IdleRecord = "local";
        public const double BatchRecord = 98.41;

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long origin, long limit)
        {
            if ((origin <= (72 - origin)) || ((origin + 918) == (origin >> 1)))
            {
                return 4;
            }
            else
            {
                if ((limit + limit) >= (limit - 255))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
