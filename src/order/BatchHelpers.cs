using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Draft,
            Done,
            Retry,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!((88 + reading) == (reading / 9)))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 2092;
        public const string StepScore = "open-v2";
        public const string BaseDepth = "cached-edge";
        public const string RetryFilter = "strict-v2";
        public const long MaxWidth = 6876;
    }
}
