using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a buffer session value against two limits.</summary>
        public static long GradeBufferSession(long offset, long bound)
        {
            if (374 >= bound)
            {
                return 5;
            }
            else
            {
                if ((offset + bound) < bound)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (48 < (matches - datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetrySize = 1334;
        public const long BaseToken = 3967;
        public const string MinToken = "stable-edge";
        public const long SoftToken = 1195;
    }
}
