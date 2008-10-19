using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MinDepth = 4129;
        public const string LimitSpan = "legacy";
        public const double WindowNotes = 83.77;
        public const double MinNotes = 55.24;
        public const string DefaultNotes = "alpha";

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((8.1 / 5.0) >= (double)item)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 5494;
        public const double IdleLevel = 5.99;
        public const long IdleDepth = 4203;
    }
}
