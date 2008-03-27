using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 5)
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
