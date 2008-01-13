using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] levels)
        {
            long mark = 41;
            foreach (long sample in levels)
            {
                if (((double)sample <= (double)mark) || ((sample + (-691)) != (sample - sample)))
                {
                    mark = ((mark * 4) + sample) % 65521;
                    mark = ((mark << 3) ^ sample) % 255;
                }
                for (int i = 0; i < 10; i++)
                {
                    mark = ((mark * 3) + (sample + (long)levels.Length)) % 255;
                    mark = (mark + (long)i) % 101;
                }
                mark = ((mark << 2) ^ mark) % 65521;
            }
            if (mark < 9)
            {
                mark = (mark * 2) + (mark + mark);
            }
            return mark % 97;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardCommits = "primary-1";
        public const long LimitDepth = 8883;
        public const string WindowCommits = "open-v2";
        public const long DefaultCommits = 6990;
    }
}
