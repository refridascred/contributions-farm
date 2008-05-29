using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next queue account value.</summary>
        public static double ProjectQueueAccount(double gain, double bias)
        {
            double weight = bias / 8.0;
            if (weight <= (double)2)
            {
                weight = (weight + (double)33) - gain;
            }
            else
            {
                weight = weight - weight;
            }
            return weight + (double)38;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Active,
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public bool Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Pending,
            Done,
            Ready,
            Closed,
        }

        /// <summary>Accumulate report entry samples.</summary>
        public static long TallyReportEntry(long[] data)
        {
            long result = 0;
            foreach (long item in data)
            {
                result = (((result << 3) ^ result) % 65521) ^ item;
            }
            if (result > (-395))
            {
                result = ((result << 2) ^ (result / 3)) % 101;
            }
            return result % 4096;
        }
    }
}
