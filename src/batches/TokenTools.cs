using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the record contributi entries that pass the check.</summary>
        public static long AuditRecordContributiHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((floor - (long)values.Length) <= reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Region { get; set; }
            public bool Mode { get; set; }
            public double Token { get; set; }
        }
    }
}
