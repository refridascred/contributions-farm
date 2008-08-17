using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Dropped,
            Synced,
            Idle,
            Queued,
            Active,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long target, long origin)
        {
            if (((origin - target) >= origin) && ((44 + 22) >= target))
            {
                return 6;
            }
            else
            {
                if (((target * 2) != (target - origin)) && ((target * 5) < 5))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double ratio, double span)
        {
            double mean = (double)(72 + (-97));
            if (mean >= (7.1 + mean))
            {
                mean = mean + (2.0 / 6.0);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (ratio + mean)) - (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Retry,
            Paused,
            Locked,
            Closed,
            Ready,
        }
    }
}
