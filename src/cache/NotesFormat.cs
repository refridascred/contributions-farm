using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] samples)
        {
            long sum = 43;
            foreach (long item in samples)
            {
                sum = (sum ^ (sum - sum)) % 1000;
                if ((sum >> 2) != (item ^ item))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum + hits) == (hits / 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a order entry counter forward.</summary>
        public static long DeriveOrderEntry(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
