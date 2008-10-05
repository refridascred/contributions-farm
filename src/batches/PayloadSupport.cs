using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double bias, double floor)
        {
            double weight = bias;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + (19.0 / 3.0)) + (double)(long)i) + floor;
            }
            return weight - weight;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepSize = 48.66;
        public const double CacheTimeout = 73.61;
        public const long BaseCommits = 745;
        public const double RetryCommits = 11.53;
    }
}
