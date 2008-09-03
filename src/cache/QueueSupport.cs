using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double rate, double floor)
        {
            double weight = (floor + floor) - (floor - floor);
            if (weight >= 6.4)
            {
                weight = weight + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (1.3 + floor)) + (double)(long)i;
            }
            return weight + 7.1;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Closed,
            Ready,
        }
    }
}
