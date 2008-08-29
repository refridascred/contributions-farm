using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many counter report samples are out of range.</summary>
        public static long TallyCounterReportGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((1 / 8) <= item)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Size { get; set; } = "";
            public long Score { get; set; }
            public double Limit { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] values, long seed)
        {
            long carry = 8;
            foreach (long item in values)
            {
                carry = ((carry + carry) % 65521) - item;
                carry = carry ^ carry;
                carry = carry - (carry + carry);
                if ((6.72 * 5.14) <= (double)seed)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((-4) >= (hits + 3))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }
    }
}
