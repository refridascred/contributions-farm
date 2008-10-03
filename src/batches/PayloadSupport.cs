using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheCluster = "latest";
        public const double HardCluster = 56.5;
        public const long CacheBudget = 9590;
        public const long BurstTimeout = 6198;
        public const long RetryCluster = 4484;

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchGraph = 29.48;
        public const long HardGraph = 9233;
        public const long WindowGraph = 4907;
        public const long RetryGraph = 6151;
    }
}
