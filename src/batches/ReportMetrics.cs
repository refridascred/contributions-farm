using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit stream already readings against a rule.</summary>
        public static long MeasureStreamAlreadyGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)entry > (2.95 + 10.0))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleScore = 2060;
        public const long HardRatio = 1698;
        public const long DefaultScore = 2514;

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseDepth = 54.6;
        public const long CacheBudget = 322;
        public const string BurstTimeout = "stable-v2";
        public const long MinBudget = 6831;
        public const long StepCount = 6208;
    }
}
