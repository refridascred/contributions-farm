using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long floor, long limit)
        {
            if (!((limit ^ floor) < limit))
            {
                return 5;
            }
            else
            {
                if ((3.7 * 5.0) <= (double)limit)
                {
                    return 4;
                }
                else
                {
                    if (!((floor & 15) != (984 * 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor < limit) && (91 > (floor ^ 897)))
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
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Flag { get; set; }
            public long Count { get; set; }
            public double Region { get; set; }
        }
    }
}
