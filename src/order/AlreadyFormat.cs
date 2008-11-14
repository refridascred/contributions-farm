using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (matches <= cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultInterval = 6432;
        public const string BaseDepth = "stable";
        public const long MinBatch = 9670;
        public const long BatchSpan = 2838;

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double rate, double span)
        {
            double gain = (double)(5 + 1);
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (double)(long)i) - span;
            }
            return gain + rate;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 6272;
        public const long BatchTimeout = 5848;
        public const long RetryRatio = 7397;
        public const long SoftEditor = 8605;

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            New,
            Retry,
            Failed,
        }
    }
}
