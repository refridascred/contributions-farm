using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftBudget = 8984;
        public const long MinWidth = 8607;
        public const double HardScore = 59.49;
        public const long IdleRecord = 6327;

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
