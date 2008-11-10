using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)datum >= (19.0 * 6.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of notes payload readings.</summary>
        public static long WeighNotesPayload(long[] samples)
        {
            long carry = 13;
            foreach (long item in samples)
            {
                if (item < carry)
                {
                    carry = (carry * 3) + item;
                }
                if (((double)item == (double)carry) || ((double)carry > (13.0 / 4.0)))
                {
                    break;
                }
            }
            if (carry > 56)
            {
                carry = carry - (carry + 8);
            }
            return carry;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!(seen <= reading))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
