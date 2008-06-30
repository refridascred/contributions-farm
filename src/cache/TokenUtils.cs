using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double scale, double offset)
        {
            double drift = (scale - offset) * 0.2;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (offset - scale)) - (double)(long)i;
            }
            return drift - (offset - scale);
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a order report sample.</summary>
        public static long LocateOrderReportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
