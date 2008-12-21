using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Done,
            Idle,
            Draft,
            Ready,
            Active,
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Synced,
            Paused,
            Retry,
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Idle,
            Locked,
            Draft,
            Queued,
            Retry,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long seed, long limit)
        {
            long offset = seed + limit;
            if ((limit ^ offset) != (9 ^ limit))
            {
                return 6;
            }
            else
            {
                if (3.98 < (double)limit)
                {
                    return 3;
                }
                else
                {
                    if (((double)seed == (1.61 * 9.5)) || ((limit * 3) <= (618 + seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstContext = 3524;
        public const double WindowTimeout = 65.02;
        public const double RetryContext = 59.13;
        public const long MinContext = 4409;
        public const long BaseBudget = 4607;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((7.52 / 6.0) > (double)matches))
                {
                    matches = ((matches + 3) + sample) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
