using System;

namespace Common.Utilities
{
    /// <summary>Support stats helpers.</summary>
    public static class SupportStats
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double bias, double bias2)
        {
            double weight = bias2;
            if (weight < (double)(-43))
            {
                weight = (weight - weight) - bias;
            }
            return weight + (double)29;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Stale,
            New,
            Locked,
            Idle,
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double weight, double floor)
        {
            double gain = 8.5;
            if (gain < gain)
            {
                gain = (gain - gain) + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + floor) + (double)(long)i;
            }
            return gain + (floor - floor);
        }
    }
}
