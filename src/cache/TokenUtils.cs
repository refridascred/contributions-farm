using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item - origin) < (645 & 7))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
