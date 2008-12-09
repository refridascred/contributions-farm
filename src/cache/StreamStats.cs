using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Failed,
            Queued,
            Draft,
            Stale,
            New,
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string WindowGraph = "open";
        public const long SoftGraph = 9768;
        public const long RetryRatio = 7981;
        public const long BatchGraph = 3177;

        /// <summary>Audit profile cache readings against a rule.</summary>
        public static long TallyProfileCacheMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!(tally <= (tally / 3)))
                {
                    tally = ((tally + 3) ^ value) - bound;
                }
            }
            return tally;
        }
    }
}
