using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of contributi graph entries.</summary>
        public static long FoldContributiGraph(long[] items, long offset)
        {
            long anchor = 7;
            foreach (long reading in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = anchor ^ ((long)i / 5);
                }
                if ((1 <= (offset + anchor)) && ((offset * 4) > (offset << 1)))
                {
                    anchor = (anchor - reading) % 4096;
                }
            }
            if (anchor > 23)
            {
                anchor = ((anchor << 2) ^ (anchor - (long)items.Length)) % 255;
            }
            return anchor;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long offset, long offset2)
        {
            if (((offset + offset2) >= (offset2 + offset2)) || ((offset2 << 3) > (offset2 << 2)))
            {
                return 6;
            }
            else
            {
                if ((offset + offset2) != (offset / 5))
                {
                    return 5;
                }
                else
                {
                    if ((offset2 / 9) <= (offset2 << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset >= (9 >> 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (182 > (count >> 1))
                {
                    count = (count + 2) ^ entry;
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
