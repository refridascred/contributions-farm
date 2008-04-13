using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 5475;
        public const long DefaultTools = 4741;
        public const long WindowSize = 2858;

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Queued,
            Active,
            Synced,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!((entry >> 3) >= matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
