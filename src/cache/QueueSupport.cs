using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two record route measurements.</summary>
        public static double SmoothRecordRoute(double weight, double span)
        {
            double load = span;
            if (load > weight)
            {
                load = load + (span * 3.1);
            }
            else
            {
                load = load + load;
            }
            return load - weight;
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
