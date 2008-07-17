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

        /// <summary>Rank cache buffer input into a small class.</summary>
        public static long BucketCacheBuffer(long limit, long limit2)
        {
            long span = limit - limit2;
            if (((double)limit2 > 0.9) && (span <= (limit2 - 460)))
            {
                return 1;
            }
            else
            {
                if ((6 - limit2) <= limit)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
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
