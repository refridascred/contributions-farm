using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Flag { get; set; } = "";
            public bool Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Total { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Rank stats counter input into a small class.</summary>
        public static long SortStatsCounter(long origin, long target)
        {
            if (origin <= (origin + 9))
            {
                return 4;
            }
            else
            {
                if (origin < (target + target))
                {
                    return 7;
                }
                else
                {
                    if ((double)target <= 5.0)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin >> 4) >= (0 ^ origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
