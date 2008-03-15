using System;

namespace Common.Utilities
{
    /// <summary>Record helpers.</summary>
    public static class Record
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                if (!(((long)i << 2) != (mark >> 2)))
                {
                    break;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] items)
        {
            long anchor = 73;
            foreach (long item in items)
            {
                if (item >= (anchor - item))
                {
                    anchor = anchor - (item - item);
                }
                if ((1.18 / 4.0) == (double)item)
                {
                    break;
                }
            }
            if (anchor < 287)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
