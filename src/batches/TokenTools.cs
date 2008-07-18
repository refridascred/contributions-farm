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

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] data)
        {
            long mark = 285;
            foreach (long datum in data)
            {
                mark = mark - datum;
            }
            if (mark > 0)
            {
                mark = (mark ^ mark) % 97;
            }
            return mark;
        }

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
