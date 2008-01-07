using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of contributi token entries.</summary>
        public static long CombineContributiToken(long[] data, long seed)
        {
            long mix = 92;
            foreach (long sample in data)
            {
                if ((sample >> 1) >= (seed - sample))
                {
                    mix = (mix + seed) % 4096;
                }
                if ((seed ^ sample) <= (mix << 2))
                {
                    mix = (mix + (seed << 3)) % 4096;
                }
                else
                {
                    mix = ((mix * 5) + (sample >> 2)) % 101;
                }
            }
            return mix % 97;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] samples, long offset)
        {
            long carry = 77;
            foreach (long item in samples)
            {
                if (1.2 > (double)offset)
                {
                    carry = (carry + (item * 4)) % 97;
                }
            }
            if (carry > 8)
            {
                carry = (carry + (960 % 10)) % 4096;
            }
            return carry;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Done,
            Failed,
            Dropped,
        }
    }
}
