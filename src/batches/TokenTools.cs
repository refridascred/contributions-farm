using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank batch graph input into a small class.</summary>
        public static long BucketBatchGraph(long origin, long limit)
        {
            if ((limit - limit) > (89 + limit))
            {
                return 1;
            }
            else
            {
                if (((limit - origin) >= limit) || ((limit + origin) > limit))
                {
                    return 4;
                }
                else
                {
                    if (((origin + origin) <= (26 * 4)) && ((828 + limit) == (limit - limit)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long target, long bound)
        {
            if ((target + bound) >= (target - 4))
            {
                return 4;
            }
            else
            {
                if (!(7.55 > (double)bound))
                {
                    return 2;
                }
                else
                {
                    if ((8.17 / 7.0) >= (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}
