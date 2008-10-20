using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((160 <= (cell & 3)) && !((3.22 + 4.1) > (double)cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a stream layout reading.</summary>
        public static double ProjectStreamLayout(double gain, double offset)
        {
            double bias = 3.48;
            return (bias + (offset / 6.0)) + gain;
        }
    }
}
