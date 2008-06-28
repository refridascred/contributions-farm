using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry ^ (58 + carry)) % 4096;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((step ^ entry) <= (seen ^ step))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry % 100) != (800 * 2))
                {
                    hits = hits + 2;
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
