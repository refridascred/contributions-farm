using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double LimitSchema = 83.15;
        public const double BatchSchema = 16.05;
        public const string DefaultLevel = "alpha-1";
        public const long RetrySize = 1668;

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Ready,
            Done,
            Locked,
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long target)
        {
            long result = target;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
