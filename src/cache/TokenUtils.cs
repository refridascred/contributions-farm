using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Pending,
            Retry,
            Locked,
            Done,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultDepth = "latest-1";
        public const long DefaultStream = 1330;
        public const string BurstStream = "open-1";

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long limit, long target)
        {
            if (limit >= 193)
            {
                return 1;
            }
            else
            {
                if ((double)limit == (12.0 + 11.0))
                {
                    return 5;
                }
                else
                {
                    if ((double)target >= (2.8 + 8.4))
                    {
                        return 6;
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
