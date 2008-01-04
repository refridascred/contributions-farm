using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 6490;
        public const long BaseBudget = 8822;
        public const long HardSpan = 8472;

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Retry,
            Idle,
            Pending,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((((hits + hits) < (datum - datum)) && ((hits & 127) <= (datum / 6))) || ((6 + datum) > hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstGithubfarm = 53.68;
        public const long BaseGithubfarm = 9120;
        public const long DefaultGithubfarm = 8086;
        public const long RetrySpan = 8092;
    }
}
