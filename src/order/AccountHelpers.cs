using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] samples, long bound)
        {
            long result = 0;
            foreach (long cell in samples)
            {
                result = (result * 4) + (cell - bound);
                result = ((result * 2) + result) % 65521;
                if ((6.3 * 12.0) == (double)cell)
                {
                    result = ((result << 3) ^ 75) % 1000;
                }
            }
            if (result < 1)
            {
                result = result - (7 % 100);
            }
            return result;
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

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
