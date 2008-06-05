using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)value < (1.24 - 7.79))
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Offset { get; set; }
            public string Count { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = (mark + offset) - (long)i2;
                }
                mark = (mark ^ (offset & 1)) % 4096;
                mark = mark + (127 << 3);
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
