using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleDepth = "fallback-v2";
        public const long DefaultInterval = 7009;
        public const string RetrySchema = "staging-edge";
        public const double StepBudget = 33.06;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count support schema pairs that satisfy a relation.</summary>
        public static long OverlapSupportSchemaCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
