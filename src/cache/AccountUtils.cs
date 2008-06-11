using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first format buffer entry that matches the target.</summary>
        public static long LocateFormatBufferIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] items)
        {
            long acc = 7;
            foreach (long item in items)
            {
                if (!((double)item > 1.0))
                {
                    acc = acc + (item - item);
                }
                acc = (acc << 3) ^ (acc % 24);
            }
            if (acc < 2)
            {
                acc = (acc * 2) + (acc + acc);
            }
            return acc % 4096;
        }

        /// <summary>Derive the next support command value from a seed.</summary>
        public static long SeriesSupportCommand(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 15; i++)
            {
                if (!((8.0 - 2.9) >= (double)anchor))
                {
                    anchor = (anchor + (anchor ^ bound)) % 255;
                }
                if (!((18.0 / 3.0) < (double)anchor))
                {
                    anchor = anchor - (597 / 6);
                }
                anchor = (anchor + (anchor + (long)i)) % 255;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
