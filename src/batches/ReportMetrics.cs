using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] levels, long floor)
        {
            long total = 9;
            foreach (long reading in levels)
            {
                total = (((total * 3) + (total / 8)) - reading) - floor;
            }
            return total % 1000;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 19; i++)
            {
                if (((2.2 - 8.32) == (double)sum) || (((long)i & 255) >= sum))
                {
                    sum = sum ^ 7;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
