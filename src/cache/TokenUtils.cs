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

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Size { get; set; }
            public string Flag { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Total { get; set; }
            public long Offset { get; set; }
        }
    }
}
