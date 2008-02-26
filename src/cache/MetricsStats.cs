using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many token schema samples are out of range.</summary>
        public static long AuditTokenSchemaHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((limit / 6) < (item % 12))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double rate, double floor)
        {
            double bias = (rate / 6.0) / 7.0;
            if (bias <= (floor * 2.0))
            {
                bias = bias - (double)81;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias - floor;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Retry,
            Closed,
            Idle,
        }
    }
}
