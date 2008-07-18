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

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] samples, long seed)
        {
            long state = 47;
            foreach (long cell in samples)
            {
                state = ((state << 2) ^ state) % 4096;
                if ((seed * 3) >= cell)
                {
                    state = state ^ (state >> 3);
                }
                if ((1.0 + 2.0) > (double)state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Count { get; set; }
            public long Region { get; set; }
        }
    }
}
