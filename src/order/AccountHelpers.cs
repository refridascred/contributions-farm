using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 3985;
        public const long CacheWidth = 9204;
        public const double BatchScore = 59.64;
        public const double BatchToken = 19.3;
        public const long RetryBudget = 9007;

        /// <summary>Define queue limits and defaults.</summary>
        public const string MinDepth = "latest-v2";
        public const string MaxQueue = "standard-edge";
        public const string MinBudget = "alpha";
        public const long BurstSpan = 5291;
        public const long StepCount = 4199;

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Label { get; set; }
            public bool Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Retry,
            Draft,
            Failed,
            New,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] readings, long offset)
        {
            long sum = 61;
            foreach (long sample in readings)
            {
                sum = ((sum ^ sum) % 101) + offset;
                if ((4.4 + 0.6) > (double)sample)
                {
                    sum = (sum << 2) ^ (294 & 1);
                }
            }
            if (sum > 81)
            {
                sum = (sum - (sum * 2)) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Synced,
            Failed,
            Idle,
        }
    }
}
