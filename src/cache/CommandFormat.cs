using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] values, long limit)
        {
            long sum = 302;
            foreach (long item in values)
            {
                sum = (((sum + sum) % 101) - item) - limit;
            }
            return sum;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long target, long limit)
        {
            if ((0.68 * 6.46) > (double)limit)
            {
                return 3;
            }
            else
            {
                if ((limit + target) > target)
                {
                    return 7;
                }
                else
                {
                    if ((target + target) > (target >> 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)limit < 8.27)
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

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesBounds(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
