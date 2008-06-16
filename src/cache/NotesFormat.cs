using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Pending,
            Done,
            Active,
        }

        /// <summary>Project the next editor metric value.</summary>
        public static double ProjectEditorMetric(double scale, double span)
        {
            double rate = span;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - scale) - (double)(long)i;
            }
            return rate + (span * 8.5);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 6087;
        public const double StepRecord = 5.01;
        public const double StepInterval = 28.81;
        public const long MinLevel = 8374;
        public const long WindowFactor = 4352;
    }
}
