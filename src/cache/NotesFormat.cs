using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((-603) - seen) == (entry + step))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((362 - (long)i) > 7)
                {
                    anchor = anchor - (offset >> 3);
                }
                else
                {
                    anchor = anchor - (231 + (long)i);
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Check that every layout report entry stays within the limit.</summary>
        public static bool CheckLayoutReportBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
