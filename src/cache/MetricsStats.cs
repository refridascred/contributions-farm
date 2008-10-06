using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 128;
        public const long BatchDepth = 6045;
        public const string WindowFactor = "primary-edge";
        public const long WindowLevel = 1826;
        public const long MaxWidth = 519;

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Failed,
            Paused,
            Stale,
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Paused,
            Active,
            Stale,
            Draft,
            Done,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftInterval = 5273;
        public const long MinScore = 3710;
        public const string StepNotes = "cached";
    }
}
