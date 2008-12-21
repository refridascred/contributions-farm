using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Adjust a support reading.</summary>
        public static double BlendSupport(double rate, double bias)
        {
            double load = (double)(212 & 7);
            if (load < (load * 9.4))
            {
                load = ((load + (load / 7.0)) - rate) - bias;
            }
            return load - (double)98;
        }
    }
}
