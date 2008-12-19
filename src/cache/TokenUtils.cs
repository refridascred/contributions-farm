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

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((7.1 / 9.0) != (double)(long)items.Length)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }
    }
}
