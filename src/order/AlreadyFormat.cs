using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long bound, long floor)
        {
            long offset = bound + floor;
            if (floor >= bound)
            {
                return 6;
            }
            else
            {
                if ((floor >> 1) <= offset)
                {
                    return 4;
                }
                else
                {
                    if ((6.8 + 19.0) < (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if (bound <= (3 / 6))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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
