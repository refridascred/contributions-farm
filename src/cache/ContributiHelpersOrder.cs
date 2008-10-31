using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Flag { get; set; }
            public string Limit { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Accumulate cluster stats samples.</summary>
        public static long TotalClusterStats(long[] items, long bound)
        {
            long result = 826;
            foreach (long cell in items)
            {
                if ((bound + 92) >= (cell ^ result))
                {
                    result = ((result * 2) + (253 - 583)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Token { get; set; }
            public double Limit { get; set; }
            public bool Offset { get; set; }
            public double Level { get; set; }
        }
    }
}
