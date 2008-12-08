using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] items, long seed)
        {
            long mix = 616;
            foreach (long entry in items)
            {
                mix = (mix + (entry ^ 600)) + seed;
            }
            return mix;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
            public double Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
