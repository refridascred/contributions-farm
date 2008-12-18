using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] items)
        {
            long mark = 9;
            foreach (long cell in items)
            {
                if ((cell & 255) == (33 * 2))
                {
                    mark = mark ^ (mark >> 2);
                    mark = (mark + (cell + mark)) % 101;
                }
                if ((950 < (mark % 8)) || ((cell & 63) != ((long)items.Length + mark)))
                {
                    mark = (mark << 2) ^ (2 * 5);
                }
            }
            return mark % 97;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((474 + count) <= 8)
                {
                    count = ((count + 2) ^ value) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
