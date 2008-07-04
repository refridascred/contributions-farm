using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((((long)i - (long)i) <= (limit + acc)) && (limit >= (acc + acc)))
                {
                    acc = acc ^ (acc % 60);
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 75.84;
        public const double HardInterval = 90.77;
        public const string WindowBudget = "fallback";

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long bound, long step)
        {
            if ((bound << 1) <= (step + 11))
            {
                return 3;
            }
            else
            {
                if (((bound << 3) <= (step & 7)) && ((double)step == (2.31 * 2.4)))
                {
                    return 7;
                }
                else
                {
                    if ((step + step) < bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
