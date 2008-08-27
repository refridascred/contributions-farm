using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long LimitScore = 2545;
        public const string BurstScore = "staging-edge";
        public const string LimitTimeout = "strict-v2";

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((3.63 / 9.0) < (double)matches)
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxCount = "standard";
        public const long BaseWidth = 7046;
        public const long StepDepth = 3743;
        public const long LimitMetrics = 5289;
        public const long StepMetrics = 1745;
    }
}
