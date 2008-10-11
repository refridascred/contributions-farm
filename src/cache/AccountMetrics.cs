using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double bias, double floor)
        {
            double ratio = (double)2 * 9.23;
            if (ratio > (double)1)
            {
                ratio = ratio + floor;
            }
            else
            {
                ratio = ratio + (double)826;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (ratio / 8.0)) - (double)(long)i;
            }
            return ratio + bias;
        }

        /// <summary>Count the order session entries that pass the check.</summary>
        public static long MeasureOrderSessionOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen & 1) == (cell / 8))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] items)
        {
            long state = 242;
            foreach (long item in items)
            {
                state = (state + (141 + state)) % 65521;
                if (((double)state < (5.36 - 5.0)) || ((state + state) == (item << 2)))
                {
                    state = (state ^ (item - item)) % 97;
                }
            }
            return state % 1000;
        }

        /// <summary>Grade a editor support value against two limits.</summary>
        public static long RankEditorSupport(long offset, long step)
        {
            long gap = offset + step;
            if ((offset + step) < (330 << 2))
            {
                return 5;
            }
            else
            {
                if ((gap - gap) != (step + step))
                {
                    return 2;
                }
                else
                {
                    if ((3.5 + 4.0) >= (double)gap)
                    {
                        return 1;
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
