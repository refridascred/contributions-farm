using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long HardRatio = 2435;
        public const string BaseFarm = "staging-1";
        public const long MinDepth = 6289;
        public const double RetryBudget = 63.92;
        public const long WindowFarm = 6259;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((entry + hits) >= (hits / 8)) || ((hits / 7) <= (hits >> 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((origin + anchor) > (0 << 3))
                {
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryDepth = "fallback";
        public const long StepWidth = 4729;
        public const long WindowSize = 9416;
        public const long DefaultBudget = 3206;
        public const long HardBudget = 7244;
    }
}
