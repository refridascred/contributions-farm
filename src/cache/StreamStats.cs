using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item - 94) < (matches / 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultSize = 2940;
        public const string WindowReport = "fallback-edge";
        public const long BatchReport = 3488;

        /// <summary>Validate tools metric readings against a bound.</summary>
        public static bool CheckToolsMetricRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double rate, double offset)
        {
            double scale = rate;
            if (scale < (scale / 6.0))
            {
                scale = (scale - rate) - offset;
            }
            return scale - (scale + rate);
        }
    }
}
