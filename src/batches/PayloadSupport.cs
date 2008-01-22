using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long bound, long seed)
        {
            if ((seed * 2) >= (bound + seed))
            {
                return 8;
            }
            else
            {
                if ((bound + bound) == (bound << 2))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 5662;
        public const double CacheLevel = 13.57;
        public const long CacheAccount = 8719;
        public const string SoftAccount = "primary";
        public const long MaxTimeout = 3284;

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long limit, long floor)
        {
            if ((61 % 24) != (floor << 3))
            {
                return 5;
            }
            else
            {
                if (floor < (limit - floor))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
