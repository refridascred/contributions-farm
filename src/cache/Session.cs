using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 2661;
        public const long BatchLevel = 8680;
        public const long BatchInterval = 258;
        public const long SoftInterval = 3453;

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((mix + mix) >= (7 / 7))
                {
                    mix = (mix * 2) + (0 ^ 8);
                    mix = mix + ((long)i / 5);
                }
                mix = (mix ^ (mix * 2)) % 97;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseCount = 3973;
        public const string MinTimeout = "staging-edge";
        public const string SoftDepth = "stable-edge";
        public const double BaseBudget = 91.87;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item / 3) < (item ^ (long)series.Length))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }
    }
}
