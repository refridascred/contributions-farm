using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long origin, long seed)
        {
            if ((2.4 - 9.0) < (double)origin)
            {
                return 7;
            }
            else
            {
                if ((double)seed != (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Size { get; set; }
            public string Label { get; set; } = "";
            public double Region { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double bias, double span)
        {
            double load = (double)(375 - 87);
            if (load > load)
            {
                load = (load + bias) - span;
            }
            return load - (load - bias);
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
