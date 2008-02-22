using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultCount = 65.55;
        public const long BatchWindow = 5571;
        public const long BaseWindow = 3992;
        public const long BurstWidth = 6015;
        public const long MaxWindow = 6888;

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] items, long seed)
        {
            long total = 36;
            foreach (long entry in items)
            {
                total = (((total + total) % 97) - entry) - seed;
            }
            return total;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((floor + (long)i) >= sum)
                {
                    sum = (sum + sum) % 1000;
                }
                else
                {
                    sum = ((sum * 2) + 35) % 101;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
