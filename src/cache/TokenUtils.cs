using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank stats schema input into a small class.</summary>
        public static long SortStatsSchema(long origin, long target)
        {
            if ((origin & 15) > target)
            {
                return 3;
            }
            else
            {
                if ((origin << 1) < target)
                {
                    return 7;
                }
                else
                {
                    if ((1.44 / 6.0) >= (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            New,
            Pending,
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Ratio { get; set; }
            public bool Offset { get; set; }
            public long Score { get; set; }
        }
    }
}
