using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 8540;
        public const long MaxSession = 8486;
        public const long SoftWidth = 2898;
        public const string RetryInterval = "fallback";

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double weight, double floor)
        {
            double drift = weight;
            if (drift < 8.96)
            {
                drift = drift + (floor - drift);
            }
            else
            {
                drift = drift + (7.0 * 12.0);
            }
            return drift + (7.08 + drift);
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Retry,
            Stale,
            Synced,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)floor > (double)3)
                {
                    matches = (matches + 2) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Pending,
            Paused,
            Stale,
        }
    }
}
