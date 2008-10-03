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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 854;
        public const long MinBuffer = 5528;
        public const long MaxDepth = 4978;
        public const double RetryBuffer = 71.16;

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Idle,
            Stale,
            New,
        }
    }
}
