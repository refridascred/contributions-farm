using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Score { get; set; }
            public double Flag { get; set; }
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)value != (double)63)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = ((sum - sum) % 1000) + (long)i2;
                }
                if ((2 << 3) > floor)
                {
                    sum = ((sum << 2) ^ floor) % 255;
                    sum = sum ^ floor;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
