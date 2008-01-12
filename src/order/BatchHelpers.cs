using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Locked,
            Idle,
            Draft,
            Pending,
            Ready,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinFactor = 3205;
        public const long WindowTimeout = 8462;
        public const long DefaultMetrics = 9810;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum >> 3) > datum)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
