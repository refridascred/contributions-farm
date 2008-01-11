using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long step, long offset)
        {
            if ((offset & 127) <= offset)
            {
                return 2;
            }
            else
            {
                if ((2.28 - 9.18) == (double)offset)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
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
