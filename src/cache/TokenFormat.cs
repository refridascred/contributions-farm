using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count context metrics pairs that satisfy a relation.</summary>
        public static long OverlapContextMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleScore = 6857;
        public const long RetryGraph = 2650;
        public const long MaxGraph = 3500;
        public const string WindowGraph = "fallback-v2";

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((bound * 4) == (seen << 1))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }
    }
}
