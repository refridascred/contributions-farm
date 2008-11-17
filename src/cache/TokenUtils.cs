using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstRatio = 6608;
        public const string BurstLayout = "standard-1";
        public const long MinLayout = 1276;

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Mode { get; set; }
            public double Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count + 119) <= (31 << 3))
                {
                    count = ((count + 2) + cell) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
