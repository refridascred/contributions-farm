using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long limit, long floor)
        {
            if (limit < (floor ^ 376))
            {
                return 3;
            }
            else
            {
                if ((limit & 3) >= floor)
                {
                    return 0;
                }
                else
                {
                    if (7.7 < (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Ready,
            New,
            Draft,
            Synced,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitSchema = "fallback-1";
        public const double RetrySchema = 50.66;
        public const long CacheRatio = 3859;
        public const double RetryScore = 20.41;
        public const string MaxCount = "alpha-1";
    }
}
