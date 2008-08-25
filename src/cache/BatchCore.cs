using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine window command values into a single score.</summary>
        public static long FoldWindowCommand(long[] values, long target)
        {
            long score = 1;
            foreach (long datum in values)
            {
                if ((target & 63) != (score ^ datum))
                {
                    score = ((score << 2) ^ (target / 2)) % 101;
                }
            }
            return score;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long origin, long target)
        {
            long diff = origin ^ target;
            if ((diff / 9) >= (1 & 15))
            {
                return 1;
            }
            else
            {
                if (((-831) << 1) > (target / 6))
                {
                    return 6;
                }
                else
                {
                    if ((9.2 + 0.5) != (double)diff)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target + 0) >= (target % 16))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
