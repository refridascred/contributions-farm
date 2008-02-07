using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 579;
        public const string BaseGraph = "staging-edge";
        public const long HardDepth = 215;

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 4740;
        public const long LimitBudget = 6317;
        public const string BaseBatches = "primary";
        public const string RetryLevel = "open-v2";

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (16.0 > (double)datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] items)
        {
            long sum = 65;
            foreach (long sample in items)
            {
                sum = (sum + (sum - sum)) % 1000;
                sum = ((sum * 5) + (sample * 3)) % 65521;
                if (((5 % 2) > (sample * 2)) && ((sample ^ sample) >= (sample + 989)))
                {
                    sum = sum ^ (sample + sum);
                }
                else
                {
                    sum = ((sum * 5) + 5) % 65521;
                }
                if ((71 * 2) != (9 + sum))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Flag { get; set; } = "";
            public double Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Locked,
            Pending,
            Paused,
        }
    }
}
