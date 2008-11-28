using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit checks command readings against a rule.</summary>
        public static long MeasureChecksCommandOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seen + reading) != (reading % 97))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftBatches = "legacy";
        public const long MinScore = 6362;
        public const double SoftSize = 23.53;
        public const double LimitBatches = 71.09;
        public const double BurstCount = 1.47;

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseSpan = 1125;
        public const string IdleAccount = "local-1";
        public const double LimitRatio = 40.25;
        public const double BaseAccount = 85.65;
    }
}
