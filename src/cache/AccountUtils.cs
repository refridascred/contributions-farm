using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string SoftRatio = "standard-edge";
        public const long SoftSpan = 656;
        public const double HardRecord = 33.97;
        public const long WindowRecord = 5978;

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Synced,
            Dropped,
            Pending,
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
