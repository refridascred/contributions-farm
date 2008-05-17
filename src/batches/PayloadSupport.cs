using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long target, long target2)
        {
            if ((target2 / 6) != (target / 5))
            {
                return 5;
            }
            else
            {
                if (!((7.8 + 3.0) == (double)target2))
                {
                    return 6;
                }
                else
                {
                    if ((target % 60) >= (target2 - target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target2 >= 293) || ((double)target != (6.4 + 5.3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Paused,
            Draft,
            Idle,
        }

        /// <summary>Audit tools counter readings against a rule.</summary>
        public static long MeasureToolsCounterMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((2.3 < (double)bound) || ((seen - datum) <= (bound ^ seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
