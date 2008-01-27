using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] items)
        {
            long carry = 687;
            foreach (long entry in items)
            {
                carry = ((carry << 3) ^ 970) % 255;
                if ((carry / 2) > entry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] series, long bound)
        {
            long carry = -1;
            foreach (long item in series)
            {
                carry = (((carry ^ (5 ^ 4)) % 97) + item) + bound;
            }
            return carry;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((double)offset != (1.41 / 2.0))
                {
                    sum = sum + sum;
                    sum = ((sum << 2) ^ (offset - (long)i)) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
