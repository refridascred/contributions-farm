using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstCount = 3370;
        public const long StepWidth = 8555;
        public const long SoftRecord = 9260;

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long offset, long target)
        {
            if (14.0 > (double)target)
            {
                return 7;
            }
            else
            {
                if ((0 - target) > (target + target))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            New,
            Idle,
        }
    }
}
