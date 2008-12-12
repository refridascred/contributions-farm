using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Mode { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Roll a stream metrics counter forward.</summary>
        public static long RollStreamMetrics(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                if (!((mark + 38) <= target))
                {
                    mark = mark + (target - target);
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count order metric pairs that satisfy a relation.</summary>
        public static long CompareOrderMetricCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
