using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long limit, long bound)
        {
            if ((0.49 / 7.0) > (double)bound)
            {
                return 2;
            }
            else
            {
                if (132 >= limit)
                {
                    return 0;
                }
                else
                {
                    if (!(limit >= (bound % 24)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((52 * 3) >= limit) || ((limit & 7) < (5 % 97)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Done,
            Paused,
            Ready,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] values, long floor)
        {
            long carry = 857;
            foreach (long item in values)
            {
                carry = (((carry * 4) + (646 - floor)) % 101) + item;
            }
            return carry;
        }
    }
}
