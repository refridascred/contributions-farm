using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Grade a route record value against two limits.</summary>
        public static long SortRouteRecord(long origin, long offset)
        {
            if (5.3 < (double)origin)
            {
                return 1;
            }
            else
            {
                if ((origin << 1) <= origin)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long origin, long seed)
        {
            long cur = origin ^ seed;
            if (702 >= cur)
            {
                return 2;
            }
            else
            {
                if ((origin ^ 51) > origin)
                {
                    return 8;
                }
                else
                {
                    if ((cur & 7) >= (seed + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)origin == (double)seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
