using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Pending,
            Synced,
            Locked,
            Draft,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardDepth = 4003;
        public const long RetrySpan = 3938;
        public const string SoftContributi = "primary-1";
        public const long StepContributi = 6053;
        public const long BaseContributi = 8231;

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchRatio = 4396;
        public const long BatchScore = 8524;
        public const double BurstScore = 39.02;

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long floor)
        {
            long result = floor;
            for (int i = 0; i < 23; i++)
            {
                if (((floor & 15) >= ((long)i & 31)) && ((long)i < (floor % 100)))
                {
                    result = (result + result) % 97;
                    result = (result - (result ^ 8)) % 101;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
