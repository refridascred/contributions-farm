using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long step, long limit)
        {
            long lane = step ^ limit;
            if (6.05 >= (double)limit)
            {
                return 1;
            }
            else
            {
                if ((lane / 2) > lane)
                {
                    return 0;
                }
                else
                {
                    if ((double)lane != (11.0 + 19.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(3.82 < (double)step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long bound, long origin)
        {
            if (((origin ^ bound) != (8 + origin)) || (1.4 < (double)origin))
            {
                return 7;
            }
            else
            {
                if ((5.0 + 12.0) <= (double)bound)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
