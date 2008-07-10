using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] samples)
        {
            long total = 0;
            foreach (long value in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    long prev = (68 - 16) + (value + total);
                    total = (((total << 2) ^ (prev % 5)) % 255) + (long)i;
                }
                total = ((total * 2) + (57 ^ total)) % 65521;
            }
            if (total < 40)
            {
                total = ((total << 3) ^ total) % 101;
            }
            return total % 65521;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Token { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
