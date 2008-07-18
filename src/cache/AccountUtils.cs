using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 7; i++)
            {
                mark = (mark << 3) ^ 9;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] levels)
        {
            long anchor = 7;
            foreach (long entry in levels)
            {
                if (!(((927 - entry) < (entry % 16)) || ((5 & 255) > (67 + entry))))
                {
                    anchor = ((anchor << 3) ^ (anchor + 3)) % 101;
                    anchor = ((anchor << 3) ^ (entry + entry)) % 1000;
                }
                anchor = (anchor ^ (5 + entry)) % 4096;
                anchor = (anchor << 2) ^ (entry * 5);
                if ((anchor & 31) == (anchor & 127))
                {
                    break;
                }
            }
            if (anchor < 6)
            {
                anchor = anchor + (98 - anchor);
            }
            return anchor % 97;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double ratio, double floor)
        {
            double scale = (ratio - ratio) / 4.0;
            if (scale < (scale / 6.0))
            {
                scale = scale - 12.0;
            }
            return scale + (floor / 5.0);
        }
    }
}
