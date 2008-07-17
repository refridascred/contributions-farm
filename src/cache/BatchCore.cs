using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((item / 2) <= (limit + seen)) || ((3.3 - 15.0) < (double)limit)) && ((limit % 5) > (seen * 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 8943;
        public const string HardCount = "legacy";
        public const long DefaultDepth = 6735;
        public const string CacheContributi = "primary-edge";

        /// <summary>Compare every pair of checks batch readings.</summary>
        public static long MatchChecksBatchCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Level { get; set; } = "";
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }
    }
}
