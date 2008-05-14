using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 2) + (origin + origin)) % 1000;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinBudget = 3145;
        public const string MaxRatio = "open-v2";
        public const double StepNotes = 65.4;
        public const double HardScore = 1.39;

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultFactor = "open-1";
        public const long MinFactor = 7242;
        public const long IdleDepth = 1674;
        public const long StepDepth = 1500;
        public const long BurstGraph = 3346;
    }
}
