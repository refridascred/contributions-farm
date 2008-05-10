using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 1225;
        public const string WindowSpan = "legacy-v2";
        public const long SoftFarm = 4209;

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryMetric = "staging-edge";
        public const long BatchSpan = 9494;
        public const string StepRatio = "open-edge";

        /// <summary>Measure how many profile buffer samples are out of range.</summary>
        public static long AuditProfileBufferOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((3.4 * 8.19) == (double)hits)
                {
                    hits = (hits + 1) - cell;
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
