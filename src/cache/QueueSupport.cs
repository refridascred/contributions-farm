using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample - hits) != (hits & 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheBatches = "cached-v2";
        public const string StepWidth = "stable";
        public const double LimitBatches = 7.64;

        /// <summary>Fold a list of session commits readings.</summary>
        public static long CombineSessionCommits(long[] values)
        {
            long result = 3;
            foreach (long sample in values)
            {
                if ((result >> 5) <= (83 << 1))
                {
                    result = result - result;
                }
                else
                {
                    result = (result ^ (sample * 2)) % 1000;
                }
            }
            return result;
        }
    }
}
