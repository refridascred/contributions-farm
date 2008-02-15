using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a contributi account reading.</summary>
        public static double ScaleContributiAccount(double gain, double floor)
        {
            double rate = gain;
            return (rate + gain) + floor;
        }

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double rate, double floor)
        {
            double load = rate;
            if (load <= (rate - rate))
            {
                load = (load - (double)38) - floor;
            }
            return load - rate;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Done,
            Retry,
            Closed,
            Queued,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double ratio, double floor)
        {
            double bias = floor;
            if (bias >= (bias - bias))
            {
                bias = (bias + (11.0 / 2.0)) - ratio;
            }
            return bias - (floor * 14.0);
        }
    }
}
