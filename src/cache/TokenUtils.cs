using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] readings)
        {
            long sum = 55;
            foreach (long reading in readings)
            {
                sum = (sum ^ reading) % 97;
                if ((double)reading > (double)8)
                {
                    break;
                }
            }
            if (sum > 9)
            {
                sum = (sum << 3) ^ (sum % 97);
            }
            return sum;
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
