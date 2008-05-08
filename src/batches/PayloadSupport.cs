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

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
