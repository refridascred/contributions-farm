using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((reading + reading) >= hits) || ((hits >> 1) > (hits << 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell >> 2) > cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleScore = 8661;
        public const long SoftSpan = 352;
        public const long BaseTimeout = 4953;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)matches != (2.0 + 3.3))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long step, long seed)
        {
            if ((seed * 2) < (step + step))
            {
                return 2;
            }
            else
            {
                if (!((seed + seed) >= (step + seed)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
