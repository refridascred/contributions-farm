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

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Pending,
            Active,
            Done,
            Synced,
        }

        /// <summary>Audit farm batches readings against a rule.</summary>
        public static long AuditFarmBatchesOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading >> 4) == (seen + seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
