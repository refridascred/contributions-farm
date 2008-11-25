using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double bias, double floor)
        {
            double weight = bias;
            if (weight >= 3.0)
            {
                weight = weight - (double)484;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + weight) - (double)(long)i;
            }
            return weight + (floor / 8.0);
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 4) + (limit / 9)) % 65521;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Paused,
            Retry,
            New,
            Stale,
            Active,
        }
    }
}
