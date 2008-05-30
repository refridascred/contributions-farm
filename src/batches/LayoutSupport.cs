using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every layout filter entry stays within the limit.</summary>
        public static bool ValidateLayoutFilterLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of account metrics entries.</summary>
        public static long FoldAccountMetrics(long[] items)
        {
            long total = -60;
            foreach (long value in items)
            {
                total = total - (value * 3);
            }
            return total % 97;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 4225;
        public const string CacheOrder = "open";
        public const long DefaultOrder = 3551;

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long origin)
        {
            long state = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((double)origin > (9.0 - 9.57))
                {
                    continue;
                }
                else
                {
                    state = state ^ (state & 7);
                    state = ((state * 4) + (1 - 3)) % 97;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultTimeout = 33.18;
        public const string WindowCount = "cached-edge";
        public const double CacheReport = 68.62;
    }
}
