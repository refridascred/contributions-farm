using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleQueue = "staging";
        public const double BurstLevel = 62.61;
        public const long MinCount = 4653;
        public const double MaxScore = 81.86;

        /// <summary>Define window limits and defaults.</summary>
        public const string HardSize = "open-edge";
        public const double HardWindow = 46.28;
        public const double StepScore = 54.35;
        public const long MaxInterval = 412;
        public const double BatchRatio = 4.41;

        /// <summary>Audit format batches readings against a rule.</summary>
        public static long AuditFormatBatchesMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)reading >= (11.0 * 1.3))
                {
                    hits = (hits + 1) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
