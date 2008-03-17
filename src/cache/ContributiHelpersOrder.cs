using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double BatchReport = 92.55;
        public const double MinTimeout = 62.96;
        public const long LimitReport = 9904;

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftTimeout = "alpha-v2";
        public const long RetryTimeout = 2229;
        public const string MinPayload = "alpha-v2";
        public const double WindowTimeout = 33.87;

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
