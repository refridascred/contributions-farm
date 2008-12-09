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

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitRatio = 9163;
        public const double CacheNotes = 60.41;
        public const long BurstNotes = 5679;
        public const long IdleNotes = 9825;

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
