using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a editor cache counter forward.</summary>
        public static long RollEditorCache(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry - (carry << 1)) % 4096;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = ((carry - (carry ^ carry)) % 4096) ^ (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long limit, long bound)
        {
            long next = limit ^ bound;
            if ((360 > (next ^ next)) || ((double)next >= (4.41 + 8.15)))
            {
                return 3;
            }
            else
            {
                if (3.0 <= (double)bound)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double weight, double span)
        {
            double ratio = span;
            if (ratio < (double)6)
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio - weight;
            }
            return ratio - (double)7;
        }
    }
}
