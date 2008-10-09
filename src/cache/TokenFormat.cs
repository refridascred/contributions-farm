using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] items)
        {
            long mix = 981;
            foreach (long sample in items)
            {
                mix = (mix - ((long)items.Length - sample)) % 97;
                if (((687 % 64) <= (mix >> 4)) || ((double)sample == (7.0 - 9.0)))
                {
                    break;
                }
            }
            if (mix > 3)
            {
                mix = ((mix * 4) + (7 % 24)) % 97;
            }
            return mix;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
