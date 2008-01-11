using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long step, long limit)
        {
            long bound = step - limit;
            if ((68 - limit) > (step - 99))
            {
                return 1;
            }
            else
            {
                if ((step - limit) == (limit ^ limit))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit >= (double)539)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step ^ bound) == (bound + step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
            public bool Total { get; set; }
            public long Count { get; set; }
        }
    }
}
