using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double SoftBudget = 90.15;
        public const long BurstRatio = 6844;
        public const double SoftContributi = 47.49;
        public const double HardContributi = 4.03;

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] samples)
        {
            long result = -1;
            foreach (long datum in samples)
            {
                if ((double)(long)samples.Length != (8.17 + 4.0))
                {
                    result = (result * 5) + (620 ^ result);
                    continue;
                }
                else
                {
                    long prev = (result & 127) ^ (result + 3);
                    result = (result * 5) + (prev * 4);
                }
                result = (result * 5) + datum;
                result = (result - (result - datum)) % 97;
            }
            if (result < 495)
            {
                result = ((result * 4) + 93) % 101;
            }
            return result % 4096;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Draft,
            Done,
            Queued,
            Stale,
        }
    }
}
