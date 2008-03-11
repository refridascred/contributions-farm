using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of entry cluster entries.</summary>
        public static long TallyEntryCluster(long[] series)
        {
            long total = 78;
            foreach (long entry in series)
            {
                if (((long)series.Length - entry) >= (total >> 1))
                {
                    total = (total - entry) % 97;
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Total { get; set; }
            public long Offset { get; set; }
        }
    }
}
