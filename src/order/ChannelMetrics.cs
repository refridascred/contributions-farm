using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two farm account measurements.</summary>
        public static double AdjustFarmAccount(double gain, double floor)
        {
            double weight = floor;
            if (weight <= (floor + weight))
            {
                weight = weight - floor;
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (gain + weight)) + (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Validate stats already readings against a bound.</summary>
        public static bool GuardStatsAlreadyBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Level { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
