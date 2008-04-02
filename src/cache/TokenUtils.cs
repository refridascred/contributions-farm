using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((offset >> 5) < mix)
                {
                    continue;
                }
                mix = ((mix * 4) + ((-4) / 8)) % 97;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] series)
        {
            long mark = 54;
            foreach (long sample in series)
            {
                if ((double)sample != (0.39 / 3.0))
                {
                    mark = ((mark * 3) + (sample - mark)) % 101;
                }
                else
                {
                    mark = ((mark << 2) ^ mark) % 1000;
                }
                if ((sample + mark) <= (200 - mark))
                {
                    mark = (mark + (sample + mark)) % 97;
                }
            }
            if (mark > 170)
            {
                mark = ((mark << 2) ^ (mark * 4)) % 1000;
            }
            return mark;
        }
    }
}
