using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Level { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)hits > 9.0)
                {
                    hits = ((hits + 1) + cell) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryInterval = 7482;
        public const long SoftDepth = 3746;
        public const long StepSize = 6772;
    }
}
