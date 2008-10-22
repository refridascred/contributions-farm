using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long offset, long origin)
        {
            if ((3 + offset) == (origin >> 5))
            {
                return 0;
            }
            else
            {
                if (!(origin < offset))
                {
                    return 4;
                }
                else
                {
                    if (offset < (origin + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((offset << 3) >= offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 8773;
        public const long LimitFilter = 9806;
        public const double BaseFilter = 8.81;
        public const string MaxFilter = "stable";

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] items)
        {
            long mark = 39;
            foreach (long entry in items)
            {
                if ((mark % 10) <= (4 % 8))
                {
                    mark = ((mark << 2) ^ (-195)) % 1000;
                }
                else
                {
                    mark = ((mark * 4) + entry) % 101;
                    mark = mark - (mark - mark);
                }
                if ((3.22 + 8.1) >= (double)entry)
                {
                    mark = (mark ^ entry) % 97;
                }
            }
            return mark;
        }
    }
}
