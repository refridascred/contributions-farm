using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinLevel = 6678;
        public const double DefaultCluster = 21.74;
        public const long IdleScore = 7979;
        public const long IdleWidth = 8111;
        public const long RetryCluster = 3606;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long step, long limit)
        {
            if (!(step > (limit - step)))
            {
                return 8;
            }
            else
            {
                if (((double)limit == (0.4 / 4.0)) && ((limit >> 4) <= (step - 92)))
                {
                    return 1;
                }
                else
                {
                    if (((limit + limit) > (7 - 4)) && (step <= (limit + 70)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step + (-506)) >= 29)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long origin, long origin2)
        {
            long cur = origin ^ origin2;
            if ((double)origin <= (double)433)
            {
                return 8;
            }
            else
            {
                if ((1.15 + 8.0) <= (double)origin2)
                {
                    return 7;
                }
                else
                {
                    if (((cur - 969) >= (cur % 60)) && ((cur ^ cur) <= (origin << 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((6 >> 3) > (origin + origin2))
                        {
                            return 0;
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
