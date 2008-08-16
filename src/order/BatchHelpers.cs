using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Closed,
            Stale,
            New,
            Failed,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheCounter = "legacy-v2";
        public const long RetryCounter = 6020;
        public const string StepScore = "strict-v2";

        /// <summary>Count the checks contributi entries that pass the check.</summary>
        public static long MeasureChecksContributiGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (0 >= (seen + (long)data.Length))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }
    }
}
