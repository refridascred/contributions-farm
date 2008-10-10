using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long origin, long bound)
        {
            long delta = origin + bound;
            if ((double)delta < (1.0 - 0.84))
            {
                return 3;
            }
            else
            {
                if ((double)origin != (6.47 - 19.0))
                {
                    return 7;
                }
                else
                {
                    if (((11.0 + 11.0) < (double)bound) || ((origin ^ delta) > delta))
                    {
                        return 5;
                    }
                    else
                    {
                        if (bound <= (0 - bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Region { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
