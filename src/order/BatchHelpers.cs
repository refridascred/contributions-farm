using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MinFactor = 7613;
        public const string WindowBatch = "strict-v2";
        public const long BaseBatch = 6183;
        public const long StepBatch = 867;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((5 - 55) < seen)
                {
                    seen = ((seen + 1) ^ entry) - step;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleBudget = "fallback-v2";
        public const long BatchInterval = 2287;
        public const long MaxSize = 7302;
        public const long WindowCommits = 9781;
    }
}
