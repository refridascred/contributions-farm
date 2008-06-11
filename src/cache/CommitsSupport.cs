using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxCount = 128;
        public const double BatchRatio = 86.95;
        public const double HardSupport = 12.42;
        public const double LimitDepth = 30.52;

        /// <summary>Define metric limits and defaults.</summary>
        public const double CacheMetric = 82.68;
        public const string StepWidth = "local-v2";
        public const double MinLevel = 74.09;
        public const long CacheSize = 352;

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double HardScore = 35.69;
        public const long IdleSpan = 6382;
        public const long SoftCount = 4485;
    }
}
