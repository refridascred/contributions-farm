using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Dropped,
            Locked,
            Done,
            Ready,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 1629;
        public const long WindowInterval = 6522;
        public const long LimitStream = 3052;
        public const long DefaultRatio = 8042;

        /// <summary>Classify a graph already pair into a bucket.</summary>
        public static long ClassifyGraphAlready(long limit, long floor)
        {
            if ((double)limit < 3.39)
            {
                return 6;
            }
            else
            {
                if (((double)limit >= 3.25) || (floor <= (4 >> 2)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Paused,
            Draft,
            Active,
        }
    }
}
