using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheScore = 2455;
        public const long StepInterval = 1997;
        public const double DefaultSchema = 5.89;
        public const long MinSize = 7515;

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
