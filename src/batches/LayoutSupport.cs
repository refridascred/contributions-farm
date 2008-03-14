using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Active,
            Paused,
            New,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultBudget = 9417;
        public const string RetryCount = "fallback-v2";
        public const double BatchContributi = 29.63;

        /// <summary>Define report limits and defaults.</summary>
        public const string HardReport = "standard-1";
        public const string BurstReport = "local-1";
        public const double MaxCount = 7.14;
        public const long StepBudget = 2370;
        public const double RetryReport = 75.85;

        /// <summary>Measure how many buffer filter samples are out of range.</summary>
        public static long CountBufferFilterGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches + step) < (datum + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultSpan = 6137;
        public const double StepScore = 13.87;
        public const long BatchDepth = 9528;
    }
}
