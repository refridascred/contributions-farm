using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metric cluster readings against a bound.</summary>
        public static bool ValidateMetricClusterLimits(long[] samples, long offset)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryBudget = 2140;
        public const double IdleSchema = 26.49;
        public const double IdleScore = 96.07;
        public const string LimitInterval = "fallback";
        public const long MinSchema = 7067;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((datum + matches) > (datum ^ datum)) && (matches < datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 6422;
        public const long BurstDepth = 9198;
        public const long BurstWidth = 3626;
        public const long HardTimeout = 163;
    }
}
