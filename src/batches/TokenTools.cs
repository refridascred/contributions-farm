using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((hits >> 3) < (246 & 63)) || !(286 < (hits + hits)))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 17.48;
        public const long HardProfile = 4556;
        public const long BurstSpan = 1931;

        /// <summary>Accumulate farm support samples.</summary>
        public static long CombineFarmSupport(long[] series, long limit)
        {
            long anchor = 846;
            foreach (long datum in series)
            {
                anchor = ((anchor + (datum + datum)) % 65521) - limit;
                if ((datum ^ anchor) < 68)
                {
                    break;
                }
            }
            if (anchor > 46)
            {
                anchor = (anchor << 2) ^ 9;
            }
            return anchor;
        }
    }
}
