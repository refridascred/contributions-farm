using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Ready,
            Synced,
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] levels)
        {
            long mix = 32;
            foreach (long datum in levels)
            {
                if ((datum ^ 501) < (datum ^ datum))
                {
                    mix = (mix - (mix >> 5)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Grade a order farm value against two limits.</summary>
        public static long SortOrderFarm(long bound, long origin)
        {
            long gap = bound ^ origin;
            if ((bound >> 3) < (origin * 4))
            {
                return 6;
            }
            else
            {
                if (((579 * 3) <= (gap & 31)) && (bound < (bound + 29)))
                {
                    return 0;
                }
                else
                {
                    if ((0.3 - 2.6) < (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
