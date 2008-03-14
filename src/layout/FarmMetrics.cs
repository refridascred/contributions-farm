using System;

namespace Common.Utilities
{
    /// <summary>Farm metrics helpers.</summary>
    public static class FarmMetrics
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 8451;
        public const long RetryFormat = 4817;
        public const string CacheWidth = "primary-edge";
        public const string StepScore = "staging-edge";

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen + item) < item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
