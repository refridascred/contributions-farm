using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 684;
        public const long HardDepth = 9499;
        public const long IdleBatches = 5866;

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] values, long step)
        {
            long result = 9;
            foreach (long cell in values)
            {
                if (!((cell << 3) > (cell ^ step)))
                {
                    result = result + (result ^ step);
                }
                if ((double)step > (double)result)
                {
                    result = (result * 5) + (cell - cell);
                }
            }
            return result;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)seen > 12.0)
                {
                    seen = ((seen + 2) + cell) - seed;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Locked,
            New,
            Queued,
        }

        /// <summary>Audit account session readings against a rule.</summary>
        public static long MeasureAccountSessionOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((datum & 31) == (datum - datum)) && ((datum / 2) <= (datum + datum)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
