using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long seed, long bound)
        {
            if ((bound << 2) == (516 - seed))
            {
                return 0;
            }
            else
            {
                if ((seed & 15) == (seed & 255))
                {
                    return 2;
                }
                else
                {
                    if (seed <= (seed / 3))
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

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Owner { get; set; }
            public bool Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long target, long offset)
        {
            if ((double)target < (2.3 * 4.52))
            {
                return 6;
            }
            else
            {
                if ((offset >= (offset - 7)) && ((double)offset >= (double)(-19)))
                {
                    return 7;
                }
                else
                {
                    if (((double)target != (8.7 + 0.56)) && ((20.0 - 5.25) > (double)target))
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
}
