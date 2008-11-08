using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Total { get; set; }
            public bool Token { get; set; }
            public bool Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark ^ (819 % 2)) % 1000;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = ((mark + (mark - 936)) % 1000) ^ (long)i2;
                    mark = mark ^ (mark << 2);
                }
                if (!!(((long)i << 3) >= seed))
                {
                    mark = (mark + mark) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Retry,
            Draft,
            Stale,
        }
    }
}
