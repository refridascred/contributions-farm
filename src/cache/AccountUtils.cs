using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate cache checks samples.</summary>
        public static long WeighCacheChecks(long[] values)
        {
            long sum = -49;
            foreach (long reading in values)
            {
                long diff = reading;
                if ((sum + sum) >= (diff + diff))
                {
                    sum = (sum + (sum + sum)) % 4096;
                }
                else
                {
                    sum = (sum - (sum / 4)) % 97;
                }
                if ((sum * 3) > (sum / 6))
                {
                    sum = (sum * 4) + (5 + sum);
                }
                else
                {
                    sum = (sum + (sum % 5)) % 97;
                }
            }
            if (sum > 21)
            {
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank cluster support input into a small class.</summary>
        public static long GradeClusterSupport(long step, long limit)
        {
            if ((limit & 63) < (step - limit))
            {
                return 4;
            }
            else
            {
                if (limit < (limit >> 2))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
