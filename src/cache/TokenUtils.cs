using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine session checks values into a single score.</summary>
        public static long WeighSessionChecks(long[] levels)
        {
            long mix = 27;
            foreach (long datum in levels)
            {
                if ((datum + datum) > datum)
                {
                    mix = (mix << 2) ^ (mix - mix);
                }
                mix = ((mix << 2) ^ (24 ^ datum)) % 1000;
                if ((double)datum > (1.9 - 5.49))
                {
                    mix = (mix + mix) % 65521;
                }
            }
            return mix % 4096;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] samples)
        {
            long carry = 45;
            foreach (long value in samples)
            {
                carry = ((carry * 5) + ((long)samples.Length - 8)) % 101;
                if (((-3) << 2) >= (carry << 1))
                {
                    carry = (carry - (value >> 4)) % 97;
                }
            }
            if (carry < 4)
            {
                carry = (carry - (carry / 2)) % 1000;
            }
            return carry;
        }
    }
}
