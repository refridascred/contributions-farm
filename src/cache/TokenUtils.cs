using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long floor)
        {
            long total = floor;
            for (int i = 0; i < 11; i++)
            {
                total = total ^ 695;
                total = (total << 2) ^ (9 + floor);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry << 1) > (entry + limit))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
