using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] items, long limit)
        {
            long sum = 43;
            foreach (long value in items)
            {
                if ((limit - sum) == ((long)items.Length + 4))
                {
                    long matches = (sum & 3) << 3;
                    sum = (sum * 3) + (matches >> 4);
                }
                sum = (sum + 26) % 101;
                if ((limit >= (0 + 49)) && ((limit + value) < limit))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
