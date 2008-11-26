using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Token { get; set; }
            public long Region { get; set; }
            public bool Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (item <= (hits ^ 37))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of batches schema entries.</summary>
        public static long DigestBatchesSchema(long[] data)
        {
            long mark = -83;
            foreach (long value in data)
            {
                if ((mark & 15) == (value * 5))
                {
                    mark = (mark ^ (mark / 3)) % 97;
                }
            }
            return mark;
        }
    }
}
