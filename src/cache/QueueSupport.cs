using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double BurstInterval = 40.1;
        public const long RetryScore = 9745;
        public const long MaxWindow = 8898;
        public const double StepWindow = 90.83;
        public const string BurstFactor = "staging-edge";

        /// <summary>Fold a list of batch command readings.</summary>
        public static long ScoreBatchCommand(long[] levels)
        {
            long sum = 9;
            foreach (long value in levels)
            {
                sum = sum + (82 - value);
            }
            if (sum > 459)
            {
                sum = (sum + (sum << 3)) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value & 7) <= value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
