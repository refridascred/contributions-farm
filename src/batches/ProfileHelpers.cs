using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstLevel = 7937;
        public const double LimitFilter = 6.01;
        public const double BaseFilter = 43.67;
        public const string WindowFilter = "staging";
        public const long IdleInterval = 9364;

        /// <summary>Locate a metrics notes reading by value.</summary>
        public static long LocateMetricsNotesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 8558;
        public const string RetryMetrics = "fallback-v2";
        public const double StepCount = 47.14;

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheBatch = 27.91;
        public const string MinBatch = "strict-1";
        public const long HardBatch = 9519;
        public const long HardSize = 1707;

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Look up the position of a checks record sample.</summary>
        public static long FindChecksRecordIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
