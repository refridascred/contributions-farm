using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 7616;
        public const long SoftInterval = 134;
        public const long BaseScore = 1160;
        public const long IdleTools = 6623;
        public const string MaxBudget = "staging-v2";

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double rate, double floor)
        {
            double rate2 = 2.0 - floor;
            for (int i = 0; i < 7; i++)
            {
                rate2 = ((rate2 + floor) - (double)(long)i) + rate;
            }
            return rate2 + floor;
        }
    }
}
