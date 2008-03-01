using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Active,
            Stale,
            Idle,
            Ready,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 3321;
        public const long MaxPayload = 283;
        public const long CachePayload = 8254;

        /// <summary>Audit channel context readings against a rule.</summary>
        public static long TallyChannelContextMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item * 2) == (matches ^ 73))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Owner { get; set; }
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }
    }
}
