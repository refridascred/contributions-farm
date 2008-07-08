using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the channel account series from a seed.</summary>
        public static long SeriesChannelAccount(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                if (!((((long)i - anchor) >= ((long)i >> 3)) && (anchor <= (27 ^ anchor))))
                {
                    anchor = anchor - 69;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] levels, long offset)
        {
            long score = 872;
            foreach (long cell in levels)
            {
                if (((offset >> 5) >= cell) || ((offset - cell) < ((long)levels.Length & 7)))
                {
                    score = score + cell;
                }
                else
                {
                    score = (score - 6) % 4096;
                }
            }
            return score;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }
    }
}
