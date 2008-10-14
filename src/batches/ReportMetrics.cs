using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string MinCount = "primary";
        public const string WindowSize = "primary-v2";
        public const long StepPayload = 2690;
        public const long RetryRatio = 2125;
        public const long BasePayload = 1646;

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen - 694) > seen)
                {
                    seen = ((seen + 1) + value) + origin;
                }
            }
            return seen;
        }
    }
}
