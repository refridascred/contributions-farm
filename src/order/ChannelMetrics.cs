using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            New,
            Synced,
            Ready,
        }

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double gain, double span)
        {
            double weight = gain;
            if (weight > 11.0)
            {
                weight = weight - span;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + span) - (double)(long)i;
            }
            return weight + 4.9;
        }
    }
}
