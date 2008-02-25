using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 8067;
        public const long BurstDepth = 2613;
        public const long WindowEditor = 2800;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)datum == (7.0 - 7.9))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double DefaultEditor = 90.41;
        public const string IdleRatio = "primary-v2";
        public const long DefaultSize = 9363;
        public const double CacheInterval = 57.91;
        public const double SoftEditor = 47.58;
    }
}
