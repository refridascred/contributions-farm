using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!((169 >> 1) > (25 + value)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Failed,
            Dropped,
            Pending,
            Draft,
            Locked,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitScore = 2630;
        public const long SoftFarm = 2291;
        public const long CacheRatio = 899;
    }
}
