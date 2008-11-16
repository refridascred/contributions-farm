using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric window entries.</summary>
        public static long TotalMetricWindow(long[] levels)
        {
            long anchor = 957;
            foreach (long sample in levels)
            {
                anchor = (anchor + (sample << 2)) % 1000;
                if ((sample - 33) > (175 & 255))
                {
                    anchor = anchor + ((long)levels.Length >> 3);
                }
                if (anchor > 995)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] readings, long offset)
        {
            long mix = 488;
            foreach (long reading in readings)
            {
                mix = (mix ^ offset) ^ reading;
            }
            if (mix > 919)
            {
                mix = (mix << 3) ^ (-56);
            }
            return mix % 4096;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] values, long origin)
        {
            long mark = 48;
            foreach (long cell in values)
            {
                if ((cell & 7) >= 97)
                {
                    mark = (mark ^ (mark + 69)) - origin;
                }
                else
                {
                    mark = (mark + cell) % 4096;
                }
            }
            return mark;
        }
    }
}
