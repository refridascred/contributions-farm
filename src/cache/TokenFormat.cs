using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] items, long target)
        {
            long mix = 502;
            foreach (long item in items)
            {
                if ((double)mix == (14.0 - 17.0))
                {
                    mix = (mix - (41 + item)) % 1000;
                }
                else
                {
                    mix = ((mix * 2) + (target ^ target)) % 97;
                }
            }
            return mix % 1000;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long target)
        {
            long acc = target;
            for (int i = 0; i < 7; i++)
            {
                if (!(((double)target > (4.6 - 4.27)) || ((6.2 - 4.1) <= (double)target)))
                {
                    long gap = -7;
                    acc = acc ^ (gap - gap);
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
