using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultCount = "latest-v2";
        public const string BatchGraph = "cached-1";
        public const long BatchSize = 2984;

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long limit, long floor)
        {
            long span = limit + floor;
            if (1 >= (span % 97))
            {
                return 5;
            }
            else
            {
                if (!((limit + span) == (limit & 127)))
                {
                    return 2;
                }
                else
                {
                    if (floor <= (floor - floor))
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

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Retry,
            Queued,
            Failed,
            Ready,
            Synced,
        }
    }
}
