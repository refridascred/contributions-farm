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

        /// <summary>Locate a commits account reading by value.</summary>
        public static long FindCommitsAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
