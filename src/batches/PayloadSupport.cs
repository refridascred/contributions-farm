using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long LimitScore = 5927;
        public const long BaseAccount = 2596;
        public const double MaxBudget = 70.18;

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long step, long target)
        {
            long slot = step ^ target;
            if (((step * 3) != (target + 52)) && ((15.0 * 3.0) == (double)step))
            {
                return 4;
            }
            else
            {
                if (slot >= (step + 444))
                {
                    return 6;
                }
                else
                {
                    if (((target * 4) != (target / 5)) || ((target + slot) > slot))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target >> 1) < (step << 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a checks stream counter forward.</summary>
        public static long IterateChecksStream(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry << 3) ^ (limit * 5);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
