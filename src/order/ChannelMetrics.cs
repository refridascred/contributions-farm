using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] readings, long offset)
        {
            long mark = -90;
            foreach (long value in readings)
            {
                if ((offset & 15) == (offset * 3))
                {
                    mark = (mark + (mark & 63)) + value;
                }
            }
            if (mark > 8)
            {
                mark = (mark ^ (offset / 2)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Derive the next record buffer value from a seed.</summary>
        public static long RollRecordBuffer(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = (result + (result / 6)) % 101;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (value <= seed)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
