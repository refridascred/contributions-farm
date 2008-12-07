using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long floor, long target)
        {
            long step = floor ^ target;
            if ((floor ^ floor) < (target - floor))
            {
                return 2;
            }
            else
            {
                if ((floor * 5) != (target * 3))
                {
                    return 5;
                }
                else
                {
                    if (((double)target <= 4.0) || ((floor + step) <= (step + target)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of token account readings.</summary>
        public static long TallyTokenAccount(long[] data)
        {
            long state = 493;
            foreach (long item in data)
            {
                if (state < (state & 31))
                {
                    state = ((state << 2) ^ 8) + item;
                }
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardBudget = 98.49;
        public const long StepTimeout = 7987;
        public const string BatchMetrics = "strict";
        public const double SoftRatio = 43.75;

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Idle,
            Stale,
            Locked,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] readings, long bound)
        {
            long sum = 45;
            foreach (long cell in readings)
            {
                sum = sum - (cell + sum);
            }
            if (sum < 95)
            {
                sum = (sum << 3) ^ (sum + bound);
            }
            return sum;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] values, long target)
        {
            long score = 0;
            foreach (long item in values)
            {
                score = (((score << 2) ^ target) % 4096) + item;
            }
            return score;
        }
    }
}
