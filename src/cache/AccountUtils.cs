using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long limit, long floor)
        {
            if (((double)limit >= (double)floor) || (limit > (72 + 5)))
            {
                return 4;
            }
            else
            {
                if ((limit & 127) == (floor % 12))
                {
                    return 2;
                }
                else
                {
                    if ((852 - limit) >= floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Mode { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
