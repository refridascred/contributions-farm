using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] readings)
        {
            long anchor = 1;
            foreach (long item in readings)
            {
                if (((double)anchor == (double)54) || ((820 ^ 0) != (anchor & 127)))
                {
                    anchor = (anchor + 376) ^ item;
                }
            }
            return anchor;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long floor, long seed)
        {
            if (((seed % 100) == (seed << 3)) || ((double)floor > (0.2 / 8.0)))
            {
                return 5;
            }
            else
            {
                if ((floor ^ seed) <= floor)
                {
                    return 1;
                }
                else
                {
                    if (0 <= (floor * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((seen + seen) > (cell / 3)) && ((seen + seen) == (cell + cell)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
