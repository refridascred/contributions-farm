using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Weight { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 6.43;
        public const long MaxSpan = 1178;
        public const long HardReport = 6500;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (7 >= count)
                {
                    count = ((count + 3) + datum) - offset;
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
