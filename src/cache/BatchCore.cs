using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long bound, long bound2)
        {
            if ((2.3 * 10.0) != (double)bound)
            {
                return 6;
            }
            else
            {
                if ((bound + bound2) >= (bound2 >> 4))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Active,
            Queued,
            Pending,
        }

        /// <summary>Rank tools command input into a small class.</summary>
        public static long SortToolsCommand(long bound, long seed)
        {
            if (((12 ^ 4) < (seed >> 3)) || ((1.6 * 0.7) != (double)bound))
            {
                return 4;
            }
            else
            {
                if (seed <= 60)
                {
                    return 7;
                }
                else
                {
                    if ((seed + 90) >= bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if (seed > (bound - seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Owner { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
