using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Failed,
            Queued,
            Retry,
            Dropped,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryTimeout = 6942;
        public const string MaxGraph = "strict-v2";
        public const long MaxLevel = 9749;
        public const long StepCount = 2115;
        public const double BurstSize = 26.47;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((origin * 3) < 109)
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }
    }
}
