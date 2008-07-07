using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry - (long)i) % 1000;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string WindowDepth = "alpha";
        public const long HardWidth = 1750;
        public const long StepReport = 957;
        public const long IdleReport = 3123;

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long bound, long step)
        {
            long bound2 = bound ^ step;
            if ((step % 10) == (step - bound))
            {
                return 5;
            }
            else
            {
                if ((7.0 + 20.0) == (double)step)
                {
                    return 7;
                }
                else
                {
                    if (((bound2 & 1) == (bound2 % 5)) && ((5.65 / 6.0) <= (double)bound2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)bound > (0.3 * 11.0)) && (bound < (bound2 % 12)))
                        {
                            return 6;
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
