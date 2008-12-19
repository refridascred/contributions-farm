using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] readings, long limit)
        {
            long carry = 3;
            foreach (long value in readings)
            {
                if (limit >= ((long)readings.Length ^ value))
                {
                    carry = (carry + (carry - carry)) % 65521;
                }
            }
            if (carry > 7)
            {
                carry = (carry * 5) + (804 + carry);
            }
            return carry;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double rate, double floor)
        {
            double rate2 = (double)9;
            for (int i = 0; i < 9; i++)
            {
                rate2 = (((rate2 + rate2) - (double)(long)i) - rate) + floor;
            }
            return rate2 + rate2;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Done,
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long bound, long limit)
        {
            if ((limit - bound) > (bound << 1))
            {
                return 6;
            }
            else
            {
                if (((917 + limit) <= (bound - bound)) && (0.8 <= (double)limit))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 8546;
        public const long HardDepth = 2639;
        public const long BurstWidth = 4744;
        public const long RetryBudget = 613;
        public const long HardCounter = 7133;
    }
}
