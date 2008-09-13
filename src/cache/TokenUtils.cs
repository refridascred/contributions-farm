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

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Total { get; set; }
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
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
