using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCount = 935;
        public const long HardCommits = 6364;
        public const string WindowInterval = "stable";
        public const string DefaultCommits = "standard-1";

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 3) + target) % 65521;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double bias, double span)
        {
            double mean = bias;
            if (mean >= bias)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + span;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - (span + mean);
        }
    }
}
