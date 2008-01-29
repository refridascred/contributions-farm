using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftDepth = 7672;
        public const long RetryLayout = 1215;
        public const string StepLayout = "local-edge";
        public const double CacheLevel = 98.42;

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((long)levels.Length + entry) < entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
