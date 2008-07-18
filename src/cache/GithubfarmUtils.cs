using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double StepStats = 4.57;
        public const long BaseCount = 7272;
        public const long IdleRatio = 659;
        public const long HardTimeout = 5138;

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchInterval = "fallback-1";
        public const long StepRatio = 7931;
        public const long SoftLayout = 946;
        public const double StepWidth = 89.4;

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] readings, long floor)
        {
            long result = 1;
            foreach (long cell in readings)
            {
                result = ((result - floor) % 97) + cell;
            }
            return result % 1000;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Count { get; set; }
            public long Region { get; set; }
        }
    }
}
