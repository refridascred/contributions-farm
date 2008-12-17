using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank channel graph input into a small class.</summary>
        public static long GradeChannelGraph(long floor, long step)
        {
            if ((6 & 1) > floor)
            {
                return 1;
            }
            else
            {
                if ((step <= (803 * 3)) || (floor >= (floor / 8)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long target)
        {
            long carry = target;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Failed,
            New,
            Idle,
            Closed,
        }
    }
}
