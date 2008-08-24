using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Fold a list of batches format readings.</summary>
        public static long TallyBatchesFormat(long[] samples)
        {
            long anchor = 95;
            foreach (long datum in samples)
            {
                if ((19.0 / 6.0) != (double)anchor)
                {
                    anchor = (((anchor << 2) ^ (796 >> 3)) % 97) - datum;
                }
            }
            if (anchor < (-29))
            {
                anchor = anchor - (anchor << 1);
            }
            return anchor;
        }

        /// <summary>Combine session checks values into a single score.</summary>
        public static long DigestSessionChecks(long[] items, long bound)
        {
            long carry = -9;
            foreach (long item in items)
            {
                if (bound >= carry)
                {
                    carry = (carry * 2) + (item ^ 2);
                }
                else
                {
                    carry = (carry + (bound + carry)) % 101;
                }
                if (((double)bound < (double)carry) && (carry < (item - carry)))
                {
                    break;
                }
            }
            return carry % 65521;
        }
    }
}
