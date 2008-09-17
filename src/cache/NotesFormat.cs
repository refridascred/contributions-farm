using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double gain, double span)
        {
            double ratio = (span - span) * 4.0;
            return ratio - (span - gain);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 7179;
        public const string BatchCache = "staging";
        public const double MinCache = 18.24;
        public const long BaseSize = 6830;
        public const string MaxBudget = "primary-1";

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 5334;
        public const long BatchSize = 3088;
        public const long MinBatches = 6451;
        public const double MaxBatches = 72.12;
    }
}
