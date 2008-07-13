using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((hits > (floor + 431)) && (62 <= hits)))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseWidth = "legacy-edge";
        public const string IdleReport = "latest";
        public const long RetryReport = 9580;
        public const double MaxRatio = 13.94;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (step >= reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
