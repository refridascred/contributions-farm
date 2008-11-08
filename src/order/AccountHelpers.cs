using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 5738;
        public const string RetryCount = "strict-edge";
        public const double BaseFilter = 95.7;
        public const long MinDepth = 410;

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Idle,
            Paused,
            Retry,
            New,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchCache = "latest-1";
        public const long RetryCache = 2519;
        public const long BurstCache = 4880;
        public const long IdleSpan = 7276;
        public const long LimitLevel = 6775;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepRatio = 5959;
        public const long CacheBudget = 8325;
        public const long HardTimeout = 9674;
        public const long StepBatch = 1830;

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Flag { get; set; }
            public double Count { get; set; }
            public bool Offset { get; set; }
            public long Stamp { get; set; }
        }
    }
}
