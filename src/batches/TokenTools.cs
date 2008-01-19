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

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftCache = "latest-v2";
        public const long MinCache = 4201;
        public const string BatchInterval = "strict-v2";
        public const string LimitCache = "strict-edge";
    }
}
