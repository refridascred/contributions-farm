using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((origin % 64) > (entry + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (matches > (item % 16))
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string RetryBatches = "staging-edge";
        public const string MinBatches = "primary-v2";
        public const double MinBudget = 64.64;
    }
}
