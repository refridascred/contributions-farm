using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long bound, long target)
        {
            long delta = bound ^ target;
            if (target < (bound >> 4))
            {
                return 4;
            }
            else
            {
                if (((target + target) >= target) && ((target + target) < (delta % 10)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
