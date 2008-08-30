using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepBudget = 9754;
        public const string WindowRatio = "fallback-v2";
        public const long MinScore = 8865;
        public const long WindowCount = 9304;

        /// <summary>Count the channel schema entries that pass the check.</summary>
        public static long AuditChannelSchemaMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!(((item - 494) >= (hits & 15)) || ((hits & 63) < (3 + item))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
