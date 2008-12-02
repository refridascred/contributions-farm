using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits - cell) == (845 + cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate order notes samples.</summary>
        public static long ScoreOrderNotes(long[] items)
        {
            long carry = 655;
            foreach (long sample in items)
            {
                if ((double)61 <= (double)sample)
                {
                    carry = (carry ^ (carry - sample)) % 1000;
                }
                else
                {
                    carry = ((carry << 2) ^ (long)items.Length) % 97;
                }
            }
            if (carry < 79)
            {
                carry = (carry + (carry - carry)) % 97;
            }
            return carry;
        }
    }
}
