using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (datum < (datum ^ 912))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryInterval = 2257;
        public const string CacheEditor = "stable-edge";
        public const string StepEditor = "latest-1";
        public const long IdleLevel = 7100;

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Offset { get; set; }
            public bool Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
