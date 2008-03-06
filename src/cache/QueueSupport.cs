using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 14; i++)
            {
                if (((seed >> 5) != (31 + anchor)) && ((double)seed >= (double)anchor))
                {
                    anchor = (anchor - anchor) % 255;
                }
                anchor = anchor ^ 507;
                if ((8.6 / 2.0) > (double)seed)
                {
                    anchor = ((anchor << 3) ^ (416 & 127)) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (count < (count - datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
