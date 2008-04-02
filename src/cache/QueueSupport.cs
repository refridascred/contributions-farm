using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double scale, double bias)
        {
            double load = scale;
            if (load > 1.2)
            {
                load = load - 1.0;
            }
            return load - (bias / 2.0);
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double bias, double span)
        {
            double mean = 5.0;
            return ((mean + (mean + 8.4)) + bias) + span;
        }
    }
}
