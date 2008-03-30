using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstFactor = 8792;
        public const string StepRatio = "legacy-1";
        public const double MinSize = 29.71;
        public const long SoftEditor = 1809;

        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowWidth = 63.67;
        public const string WindowNotes = "standard-edge";
        public const double SoftNotes = 95.32;
        public const double CacheNotes = 97.13;
        public const string CacheInterval = "primary";

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)value >= 8.0)
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }
    }
}
