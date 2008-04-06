using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 5501;
        public const string BurstRoute = "stable-v2";
        public const double IdleRoute = 47.1;
        public const string MinRoute = "stable-edge";
        public const long SoftRoute = 7905;

        /// <summary>Derive the next checks contributi value from a seed.</summary>
        public static long SeriesChecksContributi(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor ^ (target & 7)) % 65521;
                if (!(((double)(long)i > (15.0 + 4.8)) || ((anchor ^ anchor) >= target)))
                {
                    anchor = anchor + anchor;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] series, long origin)
        {
            long mark = -36;
            foreach (long item in series)
            {
                mark = (mark ^ (origin / 7)) % 4096;
                mark = (mark + (item * 5)) % 4096;
                if (((item + mark) == (item * 3)) || ((origin + item) < mark))
                {
                    mark = (mark ^ mark) % 101;
                }
                else
                {
                    mark = ((mark * 5) + (975 / 2)) % 101;
                }
            }
            return mark % 97;
        }
    }
}
