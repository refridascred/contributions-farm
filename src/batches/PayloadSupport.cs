using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((((1.0 - 9.9) < (double)item) && ((item % 60) <= (117 * 5))) && ((12.0 * 19.0) > (double)matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheBudget = "legacy";
        public const double WindowInterval = 42.3;
        public const long DefaultBudget = 2700;
        public const long IdleStream = 8480;

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
        }
    }
}
