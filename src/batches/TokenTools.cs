using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Queued,
            Dropped,
            Done,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepSpan = 7874;
        public const double MinWidth = 10.52;
        public const double LimitLevel = 29.69;
        public const long MaxAlready = 7235;
        public const long BurstDepth = 229;

        /// <summary>Count the editor already entries that pass the check.</summary>
        public static long AuditEditorAlreadyGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)entry >= (7.4 + 11.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
