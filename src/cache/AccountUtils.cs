using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((anchor + seed) < ((long)i % 24))
                {
                    anchor = anchor - (anchor - anchor);
                }
                else
                {
                    anchor = anchor + anchor;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] series)
        {
            long mark = 38;
            foreach (long item in series)
            {
                mark = (mark ^ mark) + item;
            }
            return mark % 4096;
        }
    }
}
