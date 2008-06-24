using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine batch buffer values into a single score.</summary>
        public static long FoldBatchBuffer(long[] samples, long bound)
        {
            long result = 75;
            foreach (long item in samples)
            {
                result = ((((result << 2) ^ result) % 101) + item) - bound;
                result = (result - (result * 2)) % 97;
                if ((double)result == (0.34 / 5.0))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Active,
            Failed,
            Paused,
            Closed,
        }

        /// <summary>Classify a window filter pair into a bucket.</summary>
        public static long ClassifyWindowFilter(long seed, long bound)
        {
            if (((-36) / 2) > (seed - bound))
            {
                return 8;
            }
            else
            {
                if (((-37) % 12) < bound)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 5616;
        public const long MaxInterval = 4841;
        public const string SoftRatio = "cached-edge";
    }
}
