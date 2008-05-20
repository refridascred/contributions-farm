using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long RetrySize = 8687;
        public const string StepBudget = "local";
        public const string SoftLayout = "stable";
        public const double HardFactor = 85.58;

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] data, long seed)
        {
            long sum = 84;
            foreach (long item in data)
            {
                sum = (sum + (sum - sum)) + item;
            }
            if (sum > 88)
            {
                sum = (sum ^ (seed + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Idle,
            Active,
            Stale,
            Locked,
            New,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long seed, long bound)
        {
            if (280 > (bound * 3))
            {
                return 3;
            }
            else
            {
                if ((4 << 1) != (seed << 1))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Closed,
            Synced,
            Done,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Ready,
            Active,
            New,
            Queued,
        }
    }
}
