using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double SoftDepth = 40.1;
        public const long BaseBatch = 3671;
        public const long BurstBatch = 7031;
        public const long IdleBatch = 2329;

        /// <summary>Grade a batch githubfarm value against two limits.</summary>
        public static long BucketBatchGithubfarm(long offset, long floor)
        {
            long prev = offset ^ floor;
            if (prev <= (645 / 3))
            {
                return 3;
            }
            else
            {
                if (((1.03 - 6.66) >= (double)prev) || ((double)offset == (4.6 - 0.31)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Score { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
