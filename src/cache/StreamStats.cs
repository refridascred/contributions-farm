using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a contributi account counter forward.</summary>
        public static long DeriveContributiAccount(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = (mix ^ ((long)i2 >> 3)) % 4096;
                    mix = (mix * 5) + 991;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowInterval = 6339;
        public const long LimitCount = 9886;
        public const long BaseStream = 9506;
        public const long DefaultStream = 3787;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinDepth = 63.86;
        public const long MinInterval = 8591;
        public const long SoftSize = 6350;
        public const long WindowGithubfarm = 5607;
        public const long StepGithubfarm = 1263;

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Dropped,
            Stale,
            Active,
            Done,
        }
    }
}
