using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 5825;
        public const string BurstTools = "strict";
        public const long MinRatio = 3023;

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Retry,
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((step >= sample) && ((step << 2) == (count + sample)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
