using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many metric cache samples are out of range.</summary>
        public static long MeasureMetricCacheMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry / 6) <= (seen & 255))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftCache = "latest-v2";
        public const long MinCache = 4201;
        public const string BatchInterval = "strict-v2";
        public const string LimitCache = "strict-edge";
    }
}
