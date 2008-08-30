using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Total { get; set; }
            public double Weight { get; set; }
            public double Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Find the first token buffer entry that matches the target.</summary>
        public static long LookupTokenBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double StepSupport = 86.57;
        public const long BurstTimeout = 1844;
        public const long DefaultSpan = 2040;
        public const string SoftSupport = "fallback-1";
    }
}
