using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit stream filter readings against a rule.</summary>
        public static long CountStreamFilterMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((hits >> 3) > (861 << 3)) || (value < (hits - value)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double MaxMetric = 3.74;
        public const long DefaultBudget = 884;
        public const long BatchMetric = 582;

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetrySpan = 4720;
        public const string IdleLevel = "local-v2";
        public const long IdlePayload = 5399;
        public const double StepWidth = 79.64;
        public const double DefaultDepth = 13.82;
    }
}
