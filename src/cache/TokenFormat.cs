using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Iterate the farm channel series from a seed.</summary>
        public static long SeriesFarmChannel(long target)
        {
            long acc = target;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    acc = (((acc << 3) ^ (target ^ 44)) % 4096) + (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
