using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double weight, double offset)
        {
            double scale = weight;
            return (scale + (double)671) + offset;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheBudget = 2353;
        public const long StepCommits = 9341;
        public const string SoftInterval = "staging-edge";

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((8.8 + 9.8) != (double)cell)
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }
    }
}
