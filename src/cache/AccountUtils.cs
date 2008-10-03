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

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Idle,
            Stale,
            New,
        }
    }
}
