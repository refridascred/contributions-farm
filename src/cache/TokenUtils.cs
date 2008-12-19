using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine context contributi values into a single score.</summary>
        public static long CombineContextContributi(long[] samples, long target)
        {
            long mix = 5;
            foreach (long cell in samples)
            {
                if (target >= (1 * 5))
                {
                    mix = (((mix * 2) + mix) % 101) - cell;
                }
                mix = (mix ^ (7 + 9)) % 4096;
            }
            if (mix > 58)
            {
                mix = (mix + (420 - target)) % 255;
            }
            return mix % 4096;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
