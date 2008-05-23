using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MaxBudget = 3224;
        public const string BaseRatio = "local-v2";
        public const double IdleWindow = 49.6;
        public const long MinBudget = 8446;

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Pending,
            Retry,
            Active,
            Idle,
            Ready,
        }

        /// <summary>Classify a buffer githubfarm pair into a bucket.</summary>
        public static long GradeBufferGithubfarm(long offset, long target)
        {
            if (((offset / 4) >= (offset / 6)) || ((target + 607) <= (target % 8)))
            {
                return 5;
            }
            else
            {
                if (!((double)target > 11.0))
                {
                    return 0;
                }
                else
                {
                    if (target >= (target >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
