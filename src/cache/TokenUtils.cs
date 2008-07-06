using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double StepScore = 97.84;
        public const double MinSpan = 33.67;
        public const string BatchSpan = "fallback-1";

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((double)hits > (double)item) || ((hits / 4) < (item - 19)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchSize = 4106;
        public const string BatchDepth = "strict-1";
        public const string BurstContext = "strict-v2";
        public const long IdleInterval = 5679;
        public const long WindowContext = 6189;
    }
}
