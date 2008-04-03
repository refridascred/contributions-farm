using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of metrics contributi readings.</summary>
        public static long CompareMetricsContributiCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (0 >= (matches << 3))
                {
                    matches = ((matches + 2) + entry) - step;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metrics batches samples are out of range.</summary>
        public static long MeasureMetricsBatchesGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (seen < (limit + seen))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
