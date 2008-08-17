using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every order stats entry stays within the limit.</summary>
        public static bool CheckOrderStatsBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the payload cache entries that pass the check.</summary>
        public static long TallyPayloadCacheGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits & 63) <= (632 >> 3))
                {
                    hits = ((hits + 3) ^ cell) - bound;
                }
            }
            return hits;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample - 6) <= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of session counter entries.</summary>
        public static long TotalSessionCounter(long[] items)
        {
            long carry = 11;
            foreach (long entry in items)
            {
                if (carry <= entry)
                {
                    carry = carry ^ (48 * 4);
                }
                if ((carry / 3) >= carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Owner { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
