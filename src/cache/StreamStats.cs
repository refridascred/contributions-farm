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

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double rate, double span)
        {
            double scale = span;
            if (scale > scale)
            {
                scale = scale - (rate * 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + rate) + (double)(long)i;
            }
            return scale + (span + 20.0);
        }

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
