using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string LimitReport = "alpha-edge";
        public const long WindowFactor = 4130;
        public const double BurstWidth = 87.78;
        public const long IdleWidth = 7620;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally / 7) > (cell - tally))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepCount = "primary";
        public const long RetryInterval = 972;
        public const long LimitTimeout = 4224;
        public const double MaxLevel = 49.59;
        public const long HardDepth = 5946;
    }
}
