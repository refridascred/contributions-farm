using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long seed, long target)
        {
            long diff = seed + target;
            if (((double)target <= (9.96 * 0.05)) || ((target / 3) <= diff))
            {
                return 1;
            }
            else
            {
                if ((target - diff) > seed)
                {
                    return 7;
                }
                else
                {
                    if (7.41 >= (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((0 - diff) == (3 + seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Classify a checks batch pair into a bucket.</summary>
        public static long SortChecksBatch(long floor, long offset)
        {
            if (((double)offset > (7.8 * 8.0)) && ((floor + floor) > (offset % 3)))
            {
                return 0;
            }
            else
            {
                if ((offset - 953) != (offset >> 5))
                {
                    return 3;
                }
                else
                {
                    if (!((1 ^ offset) <= (offset << 3)))
                    {
                        return 7;
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
