using System;

namespace Common.Utilities
{
    /// <summary>Record helpers.</summary>
    public static class Record
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Rank { get; set; }
            public string Total { get; set; } = "";
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
