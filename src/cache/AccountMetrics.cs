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

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] data, long floor)
        {
            long sum = 6;
            foreach (long cell in data)
            {
                sum = (((sum << 2) ^ (sum % 12)) - cell) - floor;
            }
            return sum;
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

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
