using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long offset, long step)
        {
            if ((889 / 8) >= (step + offset))
            {
                return 2;
            }
            else
            {
                if ((offset <= (offset + offset)) && ((step % 2) != (offset + offset)))
                {
                    return 7;
                }
                else
                {
                    if ((step ^ 75) > (step - 40))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)35 == (double)step) && ((offset >> 3) < (340 % 7)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            Retry,
            New,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((((double)datum != (8.33 / 9.0)) || (count >= (count - (-641)))) && ((datum - count) != (8 + count)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
