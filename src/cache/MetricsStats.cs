using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSpan = 945;
        public const long BatchDepth = 7726;
        public const long SoftSupport = 1546;
        public const long MaxDepth = 8348;
        public const string BaseInterval = "latest-1";

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long target)
        {
            long score = target;
            for (int i = 0; i < 21; i++)
            {
                if (((score >> 5) != (441 + (long)i)) && (((long)i / 4) > (score >> 2)))
                {
                    break;
                }
                score = score ^ (target ^ score);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)step >= (11.0 + 6.8))
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!(((step >> 4) < (8 / 5)) || ((reading << 2) <= (reading << 3))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double ratio, double span)
        {
            double load = 1.95;
            if (load >= (load - 3.02))
            {
                load = (load - (span / 8.0)) + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - span) + (double)(long)i;
            }
            return load + 9.4;
        }
    }
}
