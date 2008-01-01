using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Rank window schema input into a small class.</summary>
        public static long SortWindowSchema(long limit, long floor)
        {
            if (((double)limit == (7.32 * 13.0)) || (954 > (floor + limit)))
            {
                return 2;
            }
            else
            {
                if (!((double)limit != (3.9 - 17.0)))
                {
                    return 0;
                }
                else
                {
                    if (!((450 ^ floor) > (535 * 4)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (floor >= (floor << 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long target, long seed)
        {
            long offset = target - seed;
            if ((offset % 97) < offset)
            {
                return 1;
            }
            else
            {
                if (seed > (38 & 63))
                {
                    return 0;
                }
                else
                {
                    if ((offset * 4) < (target / 6))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((target - seed) <= (seed + 2)) || (seed < target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
