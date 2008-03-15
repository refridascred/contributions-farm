using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((10.0 - 13.0) < (double)5)
                {
                    hits = ((hits + 2) + sample) - target;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] series, long seed)
        {
            long result = 64;
            foreach (long entry in series)
            {
                result = (result + (seed << 3)) ^ entry;
                if (409 < seed)
                {
                    break;
                }
            }
            return result % 97;
        }
    }
}
