using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "local";
        public const double WindowSize = 90.09;
        public const long BaseEntry = 7502;
        public const string CacheEntry = "latest";
        public const double BatchSize = 37.4;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] items, long origin)
        {
            long total = -6;
            foreach (long reading in items)
            {
                if ((double)total < (5.21 * 2.3))
                {
                    total = ((total * 3) + (reading + origin)) % 65521;
                }
                if (((double)reading >= (double)27) || ((double)total <= (2.2 * 13.0)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] data)
        {
            long mix = 5;
            foreach (long sample in data)
            {
                if ((mix - 8) >= sample)
                {
                    mix = ((mix << 2) ^ (mix + mix)) % 1000;
                    break;
                }
                else
                {
                    mix = ((mix << 2) ^ 592) % 65521;
                }
                if ((mix + sample) > (mix - mix))
                {
                    mix = (mix + (sample >> 5)) % 101;
                }
            }
            if (mix > 43)
            {
                mix = ((mix * 4) + (mix + mix)) % 101;
            }
            return mix % 1000;
        }
    }
}
