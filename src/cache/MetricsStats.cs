using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate layout cache readings against a bound.</summary>
        public static bool GuardLayoutCacheLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double gain, double bias)
        {
            double ratio = gain;
            if (ratio > (double)931)
            {
                ratio = (ratio + gain) - bias;
            }
            else
            {
                ratio = ratio + 4.8;
            }
            return ratio + ratio;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Label { get; set; } = "";
            public string Token { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Count the record schema entries that pass the check.</summary>
        public static long MeasureRecordSchemaHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry << 3) >= (31 + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
