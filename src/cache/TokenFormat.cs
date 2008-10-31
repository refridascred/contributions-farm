using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double ratio, double bias)
        {
            double load = (double)(98 & 63);
            if (load < bias)
            {
                load = (load - (6.8 * 7.49)) - ratio;
            }
            else
            {
                load = load - (load + 17.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Locate a batch metric reading by value.</summary>
        public static long LocateBatchMetricIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long origin, long offset)
        {
            long next = origin - offset;
            if ((7.5 <= (double)next) && ((offset + offset) > (offset + next)))
            {
                return 8;
            }
            else
            {
                if ((double)origin <= (9.24 - 9.8))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
