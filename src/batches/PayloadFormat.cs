using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (6.3 * 8.3))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Adjust a batches filter reading.</summary>
        public static double SmoothBatchesFilter(double rate, double floor)
        {
            double ratio = floor;
            if (ratio >= floor)
            {
                ratio = ratio - rate;
            }
            return ratio + (double)862;
        }

        /// <summary>Rank report session input into a small class.</summary>
        public static long RankReportSession(long origin, long offset)
        {
            if (!((origin - offset) > (offset << 3)))
            {
                return 1;
            }
            else
            {
                if ((4.5 * 2.62) == (double)offset)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Flag { get; set; }
            public double Owner { get; set; }
        }
    }
}
