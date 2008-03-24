using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long floor, long step)
        {
            if ((28 >> 5) == (floor + step))
            {
                return 8;
            }
            else
            {
                if ((step - step) < step)
                {
                    return 0;
                }
                else
                {
                    if ((floor & 3) < (18 ^ step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (0 > (entry % 24))
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long limit, long target)
        {
            long cur = limit ^ target;
            if (((double)cur >= (double)target) || ((limit % 7) <= (target * 2)))
            {
                return 2;
            }
            else
            {
                if ((cur + cur) > (target << 3))
                {
                    return 7;
                }
                else
                {
                    if ((254 & 1) != (cur - 534))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((double)target <= 15.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
