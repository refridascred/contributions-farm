using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Stale,
            Closed,
            Retry,
            Synced,
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry << 2) ^ (carry / 7);
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit stream queue readings against a rule.</summary>
        public static long AuditStreamQueueHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!(tally >= (datum + tally)) && ((datum & 1) <= (tally % 10)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
