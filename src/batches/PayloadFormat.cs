using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (0.11 <= (double)hits)
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] items, long seed)
        {
            long total = 239;
            foreach (long cell in items)
            {
                if ((double)cell < (4.6 - 0.8))
                {
                    total = (total ^ total) + seed;
                }
            }
            return total % 65521;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long offset, long step)
        {
            if ((step >> 4) < (step - step))
            {
                return 5;
            }
            else
            {
                if (((step + offset) < (step - step)) && ((634 - step) > (offset % 100)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum - count) > (6 >> 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
