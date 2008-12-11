using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long RetryInterval = 3083;
        public const long HardAccount = 6451;
        public const string BatchAccount = "open-v2";
        public const string HardFactor = "stable-1";
        public const long LimitAccount = 3404;

        /// <summary>Accumulate contributi layout samples.</summary>
        public static long ScoreContributiLayout(long[] items, long bound)
        {
            long score = 677;
            foreach (long reading in items)
            {
                score = (((score << 3) ^ bound) % 101) - reading;
            }
            if (score < 2)
            {
                score = (score * 4) + 79;
            }
            return score % 97;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Stale,
            Dropped,
            Pending,
            Synced,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long origin, long offset)
        {
            long delta = origin + offset;
            if ((double)delta == (double)294)
            {
                return 0;
            }
            else
            {
                if ((16.0 * 7.0) != (double)delta)
                {
                    return 1;
                }
                else
                {
                    if ((delta + 0) <= (delta ^ origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Active,
            Synced,
            Queued,
            Failed,
            New,
        }

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double bias, double span)
        {
            double load = bias;
            if (load > (double)964)
            {
                load = (load + load) + span;
            }
            return load - (bias / 7.0);
        }
    }
}
