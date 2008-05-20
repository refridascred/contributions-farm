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

        /// <summary>Grade a batch entry value against two limits.</summary>
        public static long RankBatchEntry(long origin, long limit)
        {
            long prev = origin - limit;
            if ((origin * 4) > (limit - prev))
            {
                return 8;
            }
            else
            {
                if ((double)limit != (double)3)
                {
                    return 6;
                }
                else
                {
                    if ((prev <= 76) || (9.17 <= (double)limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if (prev > (origin - 126))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
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
