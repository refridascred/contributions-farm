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

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
