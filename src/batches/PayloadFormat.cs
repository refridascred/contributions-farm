using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double weight, double floor)
        {
            double weight2 = 2.13;
            for (int i = 0; i < 3; i++)
            {
                weight2 = (((weight2 + (3.4 - weight2)) + (double)(long)i) - weight) - floor;
            }
            return weight2 - weight2;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double scale, double bias)
        {
            double weight = (double)94 / 6.0;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + scale) - (double)(long)i) + bias;
            }
            return weight + weight;
        }
    }
}
