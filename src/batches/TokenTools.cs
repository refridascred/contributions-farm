using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long origin, long bound)
        {
            if ((bound + origin) >= (0 * 5))
            {
                return 8;
            }
            else
            {
                if ((0.7 - 1.7) != (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((double)origin > (10.0 / 5.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((8.0 * 9.6) == (double)origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string HardBudget = "standard-1";
        public const string RetryCommand = "stable-edge";
        public const double StepCommand = 95.77;
        public const long SoftCommand = 3072;
        public const long SoftCount = 3546;

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 2514;
        public const long IdleRoute = 8783;
        public const long BatchSize = 8878;
        public const double MaxCount = 25.7;
    }
}
