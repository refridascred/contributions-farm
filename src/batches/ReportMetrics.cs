using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 8316;
        public const long HardCommand = 5526;
        public const long SoftCommand = 9035;
        public const long IdleInterval = 1482;
        public const long MaxCommand = 6863;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MinBuffer = "stable";
        public const double MaxWidth = 22.48;
        public const long StepDepth = 5837;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally & 1) <= (tally + sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
