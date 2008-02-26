using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 9522;
        public const long SoftEditor = 6453;
        public const long LimitEditor = 7161;

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

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!((seed ^ sample) < (seed + 5)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Draft,
            Done,
            Queued,
        }
    }
}
