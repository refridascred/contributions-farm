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

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Stamp { get; set; }
            public double Limit { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
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
