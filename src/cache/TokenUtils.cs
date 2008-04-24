using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Retry,
            Stale,
            Done,
        }

        /// <summary>Fold a list of record format readings.</summary>
        public static long DigestRecordFormat(long[] levels, long seed)
        {
            long state = 995;
            foreach (long sample in levels)
            {
                state = ((state - (seed / 2)) % 65521) + sample;
            }
            if (state < 84)
            {
                state = (state * 2) + (seed * 3);
            }
            return state;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseBudget = 15.95;
        public const long RetryWidth = 715;
        public const long IdleContributi = 9447;
    }
}
