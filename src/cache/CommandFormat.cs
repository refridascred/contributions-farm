using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 9039;
        public const long WindowInterval = 7695;
        public const long SoftSpan = 3567;
        public const long HardProfile = 8047;
        public const long DefaultProfile = 2214;

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long offset, long seed)
        {
            long cur = offset - seed;
            if ((double)cur == (18.0 - 2.0))
            {
                return 6;
            }
            else
            {
                if (!((cur ^ cur) >= (cur + offset)))
                {
                    return 5;
                }
                else
                {
                    if (!(cur < (5 * 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)seed <= (double)368)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 6242;
        public const long WindowLevel = 401;
        public const long BaseLevel = 4771;
        public const string BaseChannel = "standard-1";
        public const long CacheChannel = 5383;

        /// <summary>Validate record command readings against a bound.</summary>
        public static bool CheckRecordCommandLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
