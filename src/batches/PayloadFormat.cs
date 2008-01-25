using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Ready,
            Draft,
            Failed,
            Synced,
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Ratio { get; set; }
            public bool Offset { get; set; }
            public double Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BaseFarm = 48.55;
        public const string LimitSpan = "alpha-edge";
        public const string CacheFarm = "alpha-v2";
        public const string MinTimeout = "primary-v2";
        public const long RetryScore = 5133;

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] series, long offset)
        {
            long carry = 914;
            foreach (long sample in series)
            {
                carry = ((carry * 2) + (carry << 1)) % 4096;
                if ((offset < (sample + offset)) || ((double)(long)series.Length > (5.26 + 9.8)))
                {
                    carry = (carry * 2) + (carry * 2);
                }
            }
            return carry;
        }
    }
}
