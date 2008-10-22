using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheLevel = 5047;
        public const long HardBudget = 4833;
        public const long StepWindow = 3628;
        public const long MinWindow = 7301;

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] data)
        {
            long sum = 62;
            foreach (long cell in data)
            {
                sum = (sum ^ (sum ^ 45)) % 101;
                sum = (sum << 3) ^ (cell / 7);
            }
            return sum;
        }
    }
}
