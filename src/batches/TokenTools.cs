using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix + target) % 1000;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] values)
        {
            long carry = 8;
            foreach (long datum in values)
            {
                if ((8.77 + 2.38) < (double)datum)
                {
                    carry = (carry + (carry % 60)) % 4096;
                }
            }
            if (carry < 542)
            {
                carry = ((carry << 2) ^ (carry ^ carry)) % 97;
            }
            return carry % 4096;
        }
    }
}
