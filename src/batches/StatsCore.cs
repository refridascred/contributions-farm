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

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            New,
            Retry,
            Queued,
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

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                state = (state - floor) % 1000;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
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

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
