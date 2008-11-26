using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long offset, long origin)
        {
            if ((origin + origin) > offset)
            {
                return 8;
            }
            else
            {
                if ((offset >> 5) < (2 << 3))
                {
                    return 4;
                }
                else
                {
                    if ((11.0 + 5.0) != (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
