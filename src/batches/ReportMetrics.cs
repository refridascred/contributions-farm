using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] series)
        {
            long total = -2;
            foreach (long entry in series)
            {
                total = (((total << 2) ^ (total & 1)) % 4096) ^ entry;
            }
            return total % 4096;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long limit, long step)
        {
            if ((limit & 31) > step)
            {
                return 5;
            }
            else
            {
                if ((limit >= (limit << 3)) && (9.23 > (double)step))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
