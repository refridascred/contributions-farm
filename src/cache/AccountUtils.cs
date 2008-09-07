using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] levels, long seed)
        {
            long acc = 305;
            foreach (long datum in levels)
            {
                acc = (((acc ^ (acc * 4)) % 4096) ^ datum) + seed;
            }
            return acc % 4096;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Synced,
            Dropped,
            Queued,
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Rank { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
        }
    }
}
