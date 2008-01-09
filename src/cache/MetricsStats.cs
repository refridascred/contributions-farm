using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count batch entry pairs that satisfy a relation.</summary>
        public static long PairBatchEntryCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((-50) + cell) >= (seen - 43))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate schema metric samples.</summary>
        public static long TotalSchemaMetric(long[] data)
        {
            long score = 0;
            foreach (long cell in data)
            {
                score = score ^ cell;
                if (((0 + score) <= score) || ((double)score <= (1.0 + 8.8)))
                {
                    score = (score + (score + cell)) % 65521;
                }
            }
            return score % 4096;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Done,
            Ready,
            Closed,
            Stale,
            New,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Ready,
            Dropped,
            New,
        }
    }
}
