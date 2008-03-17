using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinDepth = 5045;
        public const long LimitFarm = 3128;
        public const long IdleFactor = 6921;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits >> 2) != (hits - reading))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Pending,
            Retry,
            Dropped,
        }
    }
}
