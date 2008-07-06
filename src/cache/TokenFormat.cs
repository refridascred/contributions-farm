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

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] series, long origin)
        {
            long score = 8;
            foreach (long entry in series)
            {
                score = (((score ^ score) % 97) + entry) + origin;
            }
            return score % 1000;
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
