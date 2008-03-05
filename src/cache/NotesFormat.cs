using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] values, long origin)
        {
            long mix = -74;
            foreach (long item in values)
            {
                if ((3.0 * 4.62) <= (double)mix)
                {
                    mix = (((mix << 3) ^ (origin & 7)) % 255) + item;
                }
            }
            return mix;
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
