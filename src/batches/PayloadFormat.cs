using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit editor profile readings against a rule.</summary>
        public static long AuditEditorProfileOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (hits >= (35 & 255))
                {
                    hits = ((hits + 2) - entry) - offset;
                }
            }
            return hits;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!(((double)seen > 9.0) || ((4 + datum) > datum)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
