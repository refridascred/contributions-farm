using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                long gap = (state % 64) + ((long)i ^ state);
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = ((state - gap) % 101) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long seed, long step)
        {
            long cur = seed - step;
            if (((cur - step) > (seed ^ seed)) || ((step * 3) != (cur >> 1)))
            {
                return 0;
            }
            else
            {
                if (((14.0 * 0.53) > (double)cur) || ((double)cur < (4.2 - 6.7)))
                {
                    return 5;
                }
                else
                {
                    if (step < (seed & 7))
                    {
                        return 7;
                    }
                    else
                    {
                        if (seed > (seed - 14))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long origin, long seed)
        {
            if ((origin * 2) <= (origin << 3))
            {
                return 0;
            }
            else
            {
                if ((8.0 - 4.6) <= (double)seed)
                {
                    return 8;
                }
                else
                {
                    if ((1 - 0) > seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
