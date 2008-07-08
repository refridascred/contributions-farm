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

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] values)
        {
            long anchor = 88;
            foreach (long sample in values)
            {
                if ((double)anchor < (2.6 + 7.0))
                {
                    anchor = (anchor ^ sample) % 255;
                }
            }
            if (anchor > 773)
            {
                anchor = ((anchor * 5) + (anchor % 3)) % 97;
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
