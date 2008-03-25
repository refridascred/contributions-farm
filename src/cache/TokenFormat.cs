using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of farm stats entries.</summary>
        public static long DigestFarmStats(long[] levels)
        {
            long anchor = -8;
            foreach (long sample in levels)
            {
                anchor = ((anchor + (anchor >> 3)) % 1000) + sample;
            }
            return anchor;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Label { get; set; }
            public string Owner { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
