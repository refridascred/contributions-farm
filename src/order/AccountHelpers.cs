using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Synced,
            Draft,
            Done,
            Failed,
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Closed,
            Paused,
            Done,
            Failed,
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Paused,
            Retry,
            Queued,
            Closed,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseDepth = 8.12;
        public const long WindowTimeout = 8665;
        public const long IdleBuffer = 467;
        public const long DefaultBuffer = 4096;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum & 15) <= offset)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public long Owner { get; set; }
            public long Flag { get; set; }
        }
    }
}
