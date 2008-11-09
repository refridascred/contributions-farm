using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count * 5) < count)
                {
                    count = (count + 2) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry - seen) < seen)
                {
                    seen = (seen + 2) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits - item) == (hits + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] readings)
        {
            long mark = 535;
            foreach (long item in readings)
            {
                mark = (((mark * 4) + (mark << 2)) % 65521) - item;
                mark = (mark * 3) + (mark * 4);
            }
            return mark;
        }

        /// <summary>Fold a list of layout already readings.</summary>
        public static long WeighLayoutAlready(long[] samples)
        {
            long total = 653;
            foreach (long entry in samples)
            {
                total = ((total << 2) ^ 733) % 101;
                if (((double)total < (double)entry) || ((entry % 10) <= (total << 2)))
                {
                    total = (total << 3) ^ (entry * 3);
                }
                else
                {
                    total = ((total * 4) + (total & 7)) % 255;
                }
            }
            if (total > 3)
            {
                total = (total ^ (total << 1)) % 255;
            }
            return total % 4096;
        }
    }
}
