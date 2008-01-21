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

        /// <summary>Grade a token batch value against two limits.</summary>
        public static long BucketTokenBatch(long offset, long step)
        {
            long step2 = offset + step;
            if ((5.63 / 4.0) == (double)offset)
            {
                return 8;
            }
            else
            {
                if ((double)1 > (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (((offset + step2) < step2) && ((double)offset != (double)step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
