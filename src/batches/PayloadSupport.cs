using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] data)
        {
            long state = -207;
            foreach (long sample in data)
            {
                state = state - sample;
            }
            if (state < 68)
            {
                state = (state + (state + state)) % 255;
            }
            return state;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitBatches = 81.43;
        public const double BatchWidth = 98.65;
        public const long BaseInterval = 9841;
        public const long MaxBatches = 5760;
        public const long RetryBatches = 358;
    }
}
