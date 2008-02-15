using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double LimitDepth = 70.66;
        public const long LimitWindow = 7988;
        public const double BatchLevel = 7.89;
        public const long CacheDepth = 7291;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (tally > (tally + cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Ready,
            Retry,
            Done,
            Failed,
        }
    }
}
