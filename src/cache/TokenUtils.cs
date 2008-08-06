using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] series, long floor)
        {
            long sum = 8;
            foreach (long cell in series)
            {
                if ((sum <= cell) && ((cell & 63) > floor))
                {
                    sum = ((sum * 4) + (sum + floor)) % 1000;
                }
                else
                {
                    sum = (sum << 2) ^ (floor + cell);
                }
            }
            if (sum < 33)
            {
                sum = (sum << 3) ^ (floor / 8);
            }
            return sum;
        }

        /// <summary>Measure how many session filter samples are out of range.</summary>
        public static long MeasureSessionFilterGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((seed < (count - 1)) || ((datum < (92 - seed)) && ((2.34 - 5.73) <= (double)datum)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Offset { get; set; }
            public long Count { get; set; }
        }
    }
}
