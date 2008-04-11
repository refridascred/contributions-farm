using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank support metrics input into a small class.</summary>
        public static long RankSupportMetrics(long floor, long offset)
        {
            if ((7 ^ offset) < (4 / 5))
            {
                return 4;
            }
            else
            {
                if ((offset << 3) == (offset - 6))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor < (8.5 - 2.9))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset % 8) <= (floor - offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Stamp { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
