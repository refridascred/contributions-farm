using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)hits <= (7.0 / 4.0))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
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

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((15.0 + 9.9) != (double)target)
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }
    }
}
