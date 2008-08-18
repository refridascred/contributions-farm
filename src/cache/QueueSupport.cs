using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionRange(long[] values, long step)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double bias, double offset)
        {
            double rate = bias;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate - bias) + (double)(long)i) + offset;
            }
            return rate - bias;
        }
    }
}
