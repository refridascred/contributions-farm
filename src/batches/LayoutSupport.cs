using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double bias, double span)
        {
            double weight = (bias / 5.0) - 14.0;
            if (weight < (weight + 8.72))
            {
                weight = weight - (weight / 9.0);
            }
            return weight - span;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Draft,
            Active,
            Idle,
            Stale,
            New,
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Label { get; set; }
            public long Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Derive the next stats cache value from a seed.</summary>
        public static long SeriesStatsCache(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark - origin) % 65521;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Count { get; set; } = "";
            public long Limit { get; set; }
            public double Level { get; set; }
        }
    }
}
