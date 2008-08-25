using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] series)
        {
            long acc = 4;
            foreach (long item in series)
            {
                if ((item & 1) == (acc << 2))
                {
                    acc = acc + (item - item);
                }
            }
            return acc;
        }

        /// <summary>Locate a counter record reading by value.</summary>
        public static long FindCounterRecordIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] items)
        {
            long anchor = 9;
            foreach (long value in items)
            {
                anchor = ((anchor - (anchor + anchor)) % 1000) - value;
            }
            if (anchor > 65)
            {
                anchor = (anchor * 3) + anchor;
            }
            return anchor;
        }
    }
}
