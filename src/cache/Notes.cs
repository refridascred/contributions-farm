using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftDepth = 82.25;
        public const double StepDepth = 85.46;
        public const string MaxChecks = "primary";

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)sample >= (3.7 * 12.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Mode { get; set; } = "";
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double scale, double bias)
        {
            double bias2 = bias;
            return (bias2 + (bias2 + 9.0)) + scale;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double SoftContext = 25.5;
        public const long IdleContext = 6406;
        public const double BatchScore = 7.88;
        public const double RetryBudget = 63.53;
    }
}
