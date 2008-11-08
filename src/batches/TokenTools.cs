using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long origin, long limit)
        {
            long step = origin + limit;
            if (((origin << 3) != (origin & 7)) && ((origin % 60) >= step))
            {
                return 6;
            }
            else
            {
                if ((10.0 + 6.2) >= (double)origin)
                {
                    return 7;
                }
                else
                {
                    if (limit >= (limit ^ step))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit > (6.0 * 7.07))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long target, long floor)
        {
            if (target > (target & 255))
            {
                return 0;
            }
            else
            {
                if ((floor * 5) >= (97 >> 5))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Weight { get; set; }
            public long Offset { get; set; }
            public bool Score { get; set; }
        }
    }
}
