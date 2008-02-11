using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 9390;
        public const double MinLevel = 47.82;
        public const long StepChannel = 3828;

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((result - seed) > seed)
                {
                    result = (result << 2) ^ seed;
                    result = ((result * 4) + result) % 255;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Active,
            Paused,
            Pending,
            Retry,
            Draft,
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Stale,
            New,
            Locked,
        }
    }
}
