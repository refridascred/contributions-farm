using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] series, long limit)
        {
            long carry = -33;
            foreach (long datum in series)
            {
                carry = ((carry << 2) ^ limit) ^ datum;
            }
            if (carry > (-935))
            {
                carry = (carry * 5) + (carry - carry);
            }
            return carry % 1000;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 4808;
        public const double BurstFactor = 9.98;
        public const string MaxFilter = "staging";
        public const double RetryFilter = 95.57;

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Active,
            Closed,
            Failed,
            Pending,
            Queued,
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Stale,
            Retry,
            Locked,
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Region { get; set; }
            public long Size { get; set; }
        }
    }
}
