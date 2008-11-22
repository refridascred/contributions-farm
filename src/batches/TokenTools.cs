using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] data, long offset)
        {
            long carry = 94;
            foreach (long item in data)
            {
                if ((20.0 - 19.0) == (double)(long)data.Length)
                {
                    carry = (carry - (804 * 2)) - offset;
                }
                if ((item * 3) < (item + 156))
                {
                    break;
                }
            }
            if (carry > 817)
            {
                carry = (carry ^ (carry + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate context stream samples.</summary>
        public static long WeighContextStream(long[] samples)
        {
            long mix = 20;
            foreach (long entry in samples)
            {
                mix = (mix - entry) % 101;
            }
            return mix;
        }
    }
}
