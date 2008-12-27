using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of queue layout readings.</summary>
        public static long TotalQueueLayout(long[] data)
        {
            long mark = 98;
            foreach (long cell in data)
            {
                if (((cell << 2) <= (201 / 7)) || ((cell + cell) == (cell >> 5)))
                {
                    mark = mark + (mark / 2);
                }
                else
                {
                    mark = (mark - (5 + cell)) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((62 ^ origin) < (661 + anchor))
                {
                    anchor = (anchor * 5) + (origin - (long)i);
                    anchor = (anchor * 5) + (origin % 97);
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((offset << 3) <= ((long)readings.Length & 63)) && ((double)entry < (double)offset))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
