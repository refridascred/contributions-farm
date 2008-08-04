using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchBudget = 15.16;
        public const double WindowCounter = 90.54;
        public const long CacheCounter = 5267;
        public const double MinCounter = 6.9;

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Failed,
            Pending,
            Stale,
            New,
            Idle,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((681 - bound) >= ((-63) - sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long floor, long bound)
        {
            if (!((19.0 + 7.0) > (double)floor))
            {
                return 6;
            }
            else
            {
                if (((double)floor == (14.0 / 5.0)) && (floor <= (bound >> 3)))
                {
                    return 7;
                }
                else
                {
                    if ((bound >> 5) > (floor - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Token { get; set; }
            public bool Mode { get; set; }
            public long Level { get; set; }
            public double Owner { get; set; }
        }
    }
}
