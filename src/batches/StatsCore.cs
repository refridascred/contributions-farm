using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (seen >= ((long)values.Length << 1))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double weight, double floor)
        {
            double scale = (floor + 8.64) + floor;
            if (scale > (weight + scale))
            {
                scale = scale - floor;
            }
            else
            {
                scale = scale - (scale / 9.0);
            }
            return scale + 8.7;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double weight, double floor)
        {
            double drift = floor;
            if (drift <= (floor + 3.11))
            {
                drift = drift - drift;
            }
            return drift + (weight + weight);
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
