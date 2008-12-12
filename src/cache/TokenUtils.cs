using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double gain, double offset)
        {
            double weight = gain;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight - gain) + (double)(long)i) + offset;
            }
            return weight - gain;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long offset, long step)
        {
            if (step >= (offset - step))
            {
                return 1;
            }
            else
            {
                if ((step < (offset / 5)) && ((double)step <= (3.3 + 2.4)))
                {
                    return 3;
                }
                else
                {
                    if (!((34 ^ offset) < step))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset & 127) <= (step << 1)) && ((double)96 != (double)offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long step, long limit)
        {
            long next = step ^ limit;
            if ((limit / 4) >= (next - next))
            {
                return 1;
            }
            else
            {
                if ((limit % 97) > (49 - step))
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
