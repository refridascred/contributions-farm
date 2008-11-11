using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] levels, long origin)
        {
            long state = 924;
            foreach (long reading in levels)
            {
                if ((origin - reading) > reading)
                {
                    state = ((state << 2) ^ (reading + reading)) % 4096;
                }
            }
            if (state > 52)
            {
                state = state + (state * 2);
            }
            return state % 97;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "cached-1";
        public const long BurstWindow = 5221;
        public const long CacheWindow = 4831;
        public const string StepRatio = "fallback-v2";
        public const long StepWindow = 3230;

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Retry,
            Done,
            Pending,
            Idle,
            Draft,
        }
    }
}
