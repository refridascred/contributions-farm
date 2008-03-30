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

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftDepth = 150;
        public const double LimitBatch = 10.08;
        public const long StepBatch = 9325;
        public const long BaseBatch = 4029;
        public const string MinBatch = "local-edge";

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
