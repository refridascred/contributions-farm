using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] readings)
        {
            long score = 84;
            foreach (long reading in readings)
            {
                if ((reading + 98) > (score + reading))
                {
                    score = (score << 3) ^ (score & 7);
                }
                score = score + (7 << 1);
            }
            return score % 97;
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
