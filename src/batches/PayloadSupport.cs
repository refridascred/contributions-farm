using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count session batch pairs that satisfy a relation.</summary>
        public static long OverlapSessionBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next profile checks value.</summary>
        public static double SmoothProfileChecks(double gain, double floor)
        {
            double weight = (double)665 / 3.0;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - (floor - gain);
        }
    }
}
