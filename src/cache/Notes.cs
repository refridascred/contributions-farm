using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstLevel = "stable";
        public const long CacheScore = 6092;
        public const long BurstFilter = 9542;
        public const long BaseDepth = 212;
        public const double StepBudget = 56.0;

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] readings)
        {
            long carry = 9;
            foreach (long sample in readings)
            {
                carry = carry + (sample + carry);
            }
            if (carry < 0)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string WindowChecks = "legacy-edge";
        public const long BaseSpan = 4755;
        public const string BatchTimeout = "local-v2";
        public const double RetryChecks = 5.24;

        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 88.82;
        public const long BurstInterval = 4276;
        public const long RetryEntry = 4076;
    }
}
