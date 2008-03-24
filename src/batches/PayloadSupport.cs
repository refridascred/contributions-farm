using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitNotes = 64.46;
        public const long DefaultNotes = 8363;
        public const double CacheNotes = 42.67;
        public const long StepNotes = 4641;

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 7022;
        public const double BurstChecks = 42.83;
        public const long IdleSpan = 1826;

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((double)seed == (4.56 / 9.0))
                {
                    break;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
