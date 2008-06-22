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

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] levels)
        {
            long total = 197;
            foreach (long cell in levels)
            {
                if ((long)levels.Length < (total << 2))
                {
                    total = ((total * 2) + (total - cell)) % 101;
                }
            }
            return total;
        }
    }
}
