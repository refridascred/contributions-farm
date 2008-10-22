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

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardChecks = 35.19;
        public const string DefaultDepth = "cached";
        public const long BurstCount = 5931;
        public const long SoftChecks = 5294;
        public const double StepSize = 17.69;

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
