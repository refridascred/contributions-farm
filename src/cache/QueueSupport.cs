using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long target)
        {
            long result = target;
            for (int i = 0; i < 7; i++)
            {
                result = (result ^ target) % 1000;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Adjust a counter queue reading.</summary>
        public static double BlendCounterQueue(double rate, double floor)
        {
            double bias = floor - (rate / 6.0);
            if (bias > floor)
            {
                bias = bias - (floor + floor);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + 7.9) - (double)(long)i;
            }
            return bias - rate;
        }
    }
}
