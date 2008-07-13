using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry * 3) + (carry + (-643));
                carry = (carry + (floor - (long)i)) % 65521;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double gain, double offset)
        {
            double gain2 = gain + offset;
            if (gain2 > (gain2 + gain2))
            {
                gain2 = gain2 - (double)77;
            }
            else
            {
                gain2 = gain2 + (gain2 + offset);
            }
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 + (gain * 5.9)) + (double)(long)i;
            }
            return gain2 - (offset - 14.0);
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] samples, long seed)
        {
            long anchor = 94;
            foreach (long datum in samples)
            {
                anchor = ((anchor ^ seed) % 97) + datum;
            }
            if (anchor > 868)
            {
                anchor = (anchor + (anchor - anchor)) % 65521;
            }
            return anchor % 1000;
        }
    }
}
