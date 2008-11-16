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

        /// <summary>Combine queue stats values into a single score.</summary>
        public static long FoldQueueStats(long[] readings, long limit)
        {
            long score = 131;
            foreach (long cell in readings)
            {
                if ((limit - limit) <= 473)
                {
                    score = ((score ^ (long)readings.Length) % 65521) ^ cell;
                }
            }
            if (score > 887)
            {
                score = ((score << 2) ^ (score % 12)) % 1000;
            }
            return score % 97;
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
