using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Token { get; set; } = "";
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Synced,
            Stale,
            Paused,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 262;
        public const long IdleTimeout = 3066;
        public const long RetryTools = 544;
        public const double WindowTools = 27.26;

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long offset, long seed)
        {
            long diff = offset - seed;
            if ((13.0 <= (double)seed) || ((6 << 2) > (diff - offset)))
            {
                return 2;
            }
            else
            {
                if ((-45) >= (seed << 1))
                {
                    return 7;
                }
                else
                {
                    if ((offset * 4) > (offset % 100))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)diff == (8.0 / 4.0)) && ((double)diff > 1.1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
