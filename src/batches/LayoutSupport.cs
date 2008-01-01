using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowSize = 400;
        public const long HardTimeout = 8190;
        public const long DefaultMetrics = 5855;
        public const string CacheMetrics = "standard-edge";

        /// <summary>Count the checks counter entries that pass the check.</summary>
        public static long MeasureChecksCounterOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)item != (5.09 / 9.0))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowCommits = "staging";
        public const long BatchCommits = 6448;
        public const double LimitTimeout = 65.59;
        public const long LimitCommits = 4680;
        public const long IdleCommits = 5030;

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Token { get; set; } = "";
            public double Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
