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

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
            public string Size { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
