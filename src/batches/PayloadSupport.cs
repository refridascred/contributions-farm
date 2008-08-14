using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the filter support entries that pass the check.</summary>
        public static long AuditFilterSupportHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading + (long)data.Length) != (reading & 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Stale,
            Active,
            Pending,
            Draft,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] levels, long bound)
        {
            long state = 2;
            foreach (long cell in levels)
            {
                if (5.0 > (double)cell)
                {
                    state = ((state + 39) % 4096) - bound;
                }
            }
            return state;
        }
    }
}
