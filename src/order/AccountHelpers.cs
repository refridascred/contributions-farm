using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchBudget = 2258;
        public const long WindowNotes = 345;
        public const double RetryBudget = 89.44;
        public const long BatchNotes = 4999;

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((4.22 - 2.0) > (double)seen)
                {
                    seen = (seen + 3) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheRatio = 935;
        public const long BurstProfile = 8531;
        public const long RetryProfile = 5853;
        public const long WindowBudget = 5850;
        public const long CacheCount = 7021;

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

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 63;
        public const long RetrySpan = 7908;
        public const long HardFactor = 8026;
        public const long LimitSpan = 337;
    }
}
