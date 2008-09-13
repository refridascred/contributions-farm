using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Count { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((double)reading == (8.0 * 19.0)) || ((double)reading < (20.0 * 0.8)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long limit, long limit2)
        {
            if ((limit2 << 1) <= limit2)
            {
                return 1;
            }
            else
            {
                if ((2 ^ limit2) > 3)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
