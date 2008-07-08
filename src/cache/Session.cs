using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowProfile = 88.53;
        public const double BaseProfile = 78.99;
        public const double BatchProfile = 76.71;

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Failed,
            Pending,
            Locked,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheInterval = 8280;
        public const long SoftStats = 4821;
        public const long BatchDepth = 3782;
        public const long WindowRatio = 2045;
        public const long LimitStats = 2028;

        /// <summary>Find the first metrics notes entry that matches the target.</summary>
        public static long FindMetricsNotesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
