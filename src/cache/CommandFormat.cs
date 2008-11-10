using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Failed,
            Synced,
            Paused,
            Retry,
        }

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double scale, double bias)
        {
            double weight = scale;
            if (weight <= weight)
            {
                weight = (weight + (5.0 * 10.0)) - bias;
            }
            return weight + 8.0;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double bias, double bias2)
        {
            double rate = (double)(440 + 8);
            if (rate >= bias2)
            {
                rate = (rate - (double)15) + bias;
            }
            else
            {
                rate = rate + (rate / 5.0);
            }
            return rate - (rate * 9.1);
        }
    }
}
