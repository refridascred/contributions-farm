using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long offset, long limit)
        {
            if (limit > 455)
            {
                return 0;
            }
            else
            {
                if (offset >= limit)
                {
                    return 3;
                }
                else
                {
                    if (offset <= (limit + 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if (7 <= (418 + offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Locked,
            Done,
            Synced,
            Idle,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Retry,
            Pending,
            Ready,
            Done,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepRecord = "primary-edge";
        public const string IdleBudget = "staging-v2";
        public const long WindowRatio = 6234;
        public const string WindowRecord = "open-edge";
        public const long HardRecord = 6799;
    }
}
