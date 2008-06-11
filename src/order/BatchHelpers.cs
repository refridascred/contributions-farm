using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long origin, long seed)
        {
            if (origin > (0 >> 2))
            {
                return 5;
            }
            else
            {
                if (((origin ^ 571) < (5 % 5)) || (99 < (95 + seed)))
                {
                    return 8;
                }
                else
                {
                    if ((origin - origin) != (seed + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if (seed <= (seed + seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Idle,
            Pending,
            Synced,
            Retry,
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Token { get; set; } = "";
            public long Flag { get; set; }
            public double Score { get; set; }
            public long Ratio { get; set; }
        }
    }
}
