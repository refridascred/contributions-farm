using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a route window value against two limits.</summary>
        public static long GradeRouteWindow(long origin, long seed)
        {
            long delta = origin - seed;
            if ((seed + 4) == (delta + 47))
            {
                return 6;
            }
            else
            {
                if ((double)seed <= (17.0 * 3.01))
                {
                    return 5;
                }
                else
                {
                    if ((0.4 - 14.0) > (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((delta < (seed & 255)) || ((origin << 2) > (delta + seed)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate batches contributi readings against a bound.</summary>
        public static bool VerifyBatchesContributiBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long step)
        {
            long state = step;
            for (int i = 0; i < 8; i++)
            {
                if (44 >= state)
                {
                    state = (state << 3) ^ ((long)i * 4);
                    state = (state ^ (step % 10)) % 255;
                }
                else
                {
                    state = ((state * 4) + ((long)i - (long)i)) % 97;
                }
                state = ((state * 4) + (step - state)) % 65521;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
