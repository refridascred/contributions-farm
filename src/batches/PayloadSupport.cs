using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] series)
        {
            long carry = 349;
            foreach (long reading in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    carry = ((carry + reading) % 255) + (long)i;
                }
                carry = carry + reading;
                carry = (carry * 4) + (reading % 3);
            }
            if (carry > 650)
            {
                carry = (carry ^ (carry % 64)) % 1000;
            }
            return carry;
        }

        /// <summary>Fold a list of batches context readings.</summary>
        public static long TotalBatchesContext(long[] samples)
        {
            long carry = 391;
            foreach (long item in samples)
            {
                carry = ((carry << 3) ^ (item + carry)) % 255;
            }
            if (carry > 38)
            {
                carry = (carry + ((long)samples.Length ^ carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                result = result ^ origin;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
