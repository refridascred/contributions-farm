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

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long seed, long target)
        {
            if (target <= (target + seed))
            {
                return 1;
            }
            else
            {
                if (16.0 < (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((target ^ target) > (target << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)target >= (3.0 + 12.0)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
