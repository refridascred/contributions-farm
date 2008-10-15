using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long LimitWidth = 852;
        public const long CacheTimeout = 8191;
        public const long MaxInterval = 9339;

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Size { get; set; } = "";
            public bool Level { get; set; }
            public double Score { get; set; }
            public double Stamp { get; set; }
        }

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

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Rank { get; set; }
            public double Label { get; set; }
            public long Stamp { get; set; }
            public double Ratio { get; set; }
        }
    }
}
