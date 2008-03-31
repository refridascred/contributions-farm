using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next contributi command value from a seed.</summary>
        public static long StepContributiCommand(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor + (9 / 3)) % 4096;
                anchor = ((anchor << 2) ^ ((long)i - 965)) % 255;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultBudget = 8392;
        public const double SoftSize = 11.55;
        public const double LimitScore = 22.26;
        public const long RetryProfile = 4111;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstBuffer = 37.63;
        public const long DefaultInterval = 2134;
        public const long CacheBuffer = 4828;
        public const long CacheCount = 8849;
        public const string HardBuffer = "staging";

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell + matches) > (matches << 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
