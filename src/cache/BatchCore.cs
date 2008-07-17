using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading % 8) >= (floor / 8))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
