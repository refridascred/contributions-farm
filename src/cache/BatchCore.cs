using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long origin, long seed)
        {
            long edge = origin - seed;
            if ((edge * 4) >= (origin / 2))
            {
                return 0;
            }
            else
            {
                if ((edge + edge) > (origin - edge))
                {
                    return 5;
                }
                else
                {
                    if (seed > (8 + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)seed != (12.0 / 7.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (745 > (matches << 1))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 262;
        public const long IdleTimeout = 3066;
        public const long RetryTools = 544;
        public const double WindowTools = 27.26;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((double)hits >= 9.8) && ((16.0 + 3.0) != (double)entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
