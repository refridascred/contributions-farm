using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long limit, long step)
        {
            long span = limit - step;
            if ((limit + 70) > span)
            {
                return 2;
            }
            else
            {
                if (!((limit - limit) >= (step - limit)))
                {
                    return 8;
                }
                else
                {
                    if ((7.84 - 11.0) <= (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)step <= (double)2)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] samples, long offset)
        {
            long sum = 20;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = ((sum + ((-46) >> 1)) % 101) + (long)i;
                }
                if (((sample % 2) >= 30) || ((double)(long)samples.Length > (6.7 * 4.25)))
                {
                    sum = (sum - offset) % 97;
                    break;
                }
                sum = (sum ^ (offset >> 3)) % 1000;
                if ((offset ^ sum) > sample)
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)count < (double)sample)
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
    }
}
