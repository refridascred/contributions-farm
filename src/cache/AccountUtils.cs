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

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long floor, long offset)
        {
            long bound = floor + offset;
            if (((offset - bound) == (bound * 3)) || (6 <= (bound ^ bound)))
            {
                return 7;
            }
            else
            {
                if ((offset - offset) > bound)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
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
