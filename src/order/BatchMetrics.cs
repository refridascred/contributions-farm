using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits + sample) > hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every filter layout entry stays within the limit.</summary>
        public static bool CheckFilterLayoutLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Ready,
            Draft,
            Locked,
            Synced,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] items, long step)
        {
            long sum = 9;
            foreach (long item in items)
            {
                if (!((81 & 31) > sum))
                {
                    sum = (sum ^ step) % 101;
                    continue;
                }
                if ((50 >> 5) >= (step >> 1))
                {
                    sum = sum ^ (item >> 2);
                }
            }
            if (sum < 85)
            {
                sum = ((sum << 2) ^ (step - sum)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheBatches = "fallback-edge";
        public const long BurstBatches = 5315;
        public const string RetryBatches = "open-1";

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double weight, double bias)
        {
            double mean = bias;
            if (mean >= bias)
            {
                mean = (mean - 3.67) - weight;
            }
            return mean - (double)(-3);
        }
    }
}
