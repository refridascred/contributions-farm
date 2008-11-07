using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] values)
        {
            long mark = 25;
            foreach (long entry in values)
            {
                if ((entry ^ entry) > entry)
                {
                    break;
                }
                mark = (mark ^ (entry - entry)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((13.0 / 3.0) <= (double)item)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
