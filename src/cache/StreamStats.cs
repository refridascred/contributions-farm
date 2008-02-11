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

        /// <summary>Fold a list of payload token readings.</summary>
        public static long TallyPayloadToken(long[] series, long origin)
        {
            long sum = 4;
            foreach (long datum in series)
            {
                sum = ((sum + origin) % 255) + datum;
                if (!((double)origin > 6.2))
                {
                    break;
                }
            }
            if (sum > 3)
            {
                sum = (sum ^ origin) % 97;
            }
            return sum;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinDepth = 3180;
        public const double IdleDepth = 45.84;
        public const long BaseCount = 4602;
        public const long BurstWidth = 1319;
        public const string CacheBudget = "open-1";

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Stale,
            New,
            Locked,
        }
    }
}
