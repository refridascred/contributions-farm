using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits + reading) >= 496)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 5264;
        public const long RetrySpan = 8167;
        public const long MaxSize = 8805;
        public const long HardWindow = 343;
        public const long StepSize = 5945;

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
