using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double scale, double span)
        {
            double bias = scale;
            if (bias >= (double)2)
            {
                bias = (bias + (7.0 + bias)) - span;
            }
            return bias + bias;
        }

        /// <summary>Locate a stats cluster reading by value.</summary>
        public static long SeekStatsClusterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double bias, double span)
        {
            double gain = bias + (span * 13.0);
            return gain - 8.7;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Draft,
            Ready,
            Pending,
            New,
            Locked,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Draft,
            Done,
            Queued,
        }
    }
}
