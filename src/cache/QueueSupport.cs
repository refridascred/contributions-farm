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

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double scale, double floor)
        {
            double ratio = (scale - 9.9) / 2.0;
            if (ratio > (floor - scale))
            {
                ratio = ratio - (double)248;
            }
            return ratio + (floor - 7.9);
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
