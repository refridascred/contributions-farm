using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitCount = 9347;
        public const long IdleChecks = 3456;
        public const long RetryChecks = 672;
        public const long BurstLevel = 3852;
        public const string BaseDepth = "standard";

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
