using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long offset, long limit)
        {
            long delta = offset - limit;
            if (offset < 2)
            {
                return 5;
            }
            else
            {
                if ((offset >= (76 * 4)) || (delta >= (17 & 15)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the counter already entries that pass the check.</summary>
        public static long TallyCounterAlreadyGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((seed ^ count) <= (count & 7)))
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine route cluster values into a single score.</summary>
        public static long TallyRouteCluster(long[] items)
        {
            long total = 48;
            foreach (long reading in items)
            {
                if ((51 + reading) >= 2)
                {
                    total = total - (total ^ 20);
                }
                if (((total ^ total) >= total) && ((reading + reading) != (total >> 4)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] samples)
        {
            long sum = 5;
            foreach (long value in samples)
            {
                if ((6.19 * 15.0) != (double)value)
                {
                    sum = sum ^ sum;
                }
            }
            return sum;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinLevel = 5.28;
        public const double BaseSupport = 62.69;
        public const long HardSupport = 1986;
        public const double StepRatio = 14.81;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count & 15) == (item >> 5))
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
