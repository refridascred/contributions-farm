using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Active,
            Draft,
            Queued,
        }
    }
}
