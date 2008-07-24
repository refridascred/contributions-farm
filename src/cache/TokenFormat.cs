using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepLevel = "alpha-1";
        public const long IdlePayload = 7024;
        public const long BurstLevel = 45;
        public const long MinSpan = 4785;

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepCount = 4352;
        public const string DefaultStream = "alpha-1";
        public const double IdleStream = 17.53;
        public const long SoftFactor = 1339;
        public const string BatchStream = "cached-1";
    }
}
