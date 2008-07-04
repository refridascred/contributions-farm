using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Active,
            Retry,
            Synced,
            Queued,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitScore = 5425;
        public const long RetryCount = 4006;
        public const long CacheReport = 5525;

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] levels, long offset)
        {
            long mark = 717;
            foreach (long entry in levels)
            {
                mark = (mark - (entry + 9)) - offset;
            }
            return mark;
        }
    }
}
