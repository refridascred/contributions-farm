using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double WindowRatio = 30.0;
        public const long MinOrder = 7711;
        public const long BatchOrder = 2922;

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i * 4) < ((long)i << 1))
                {
                    result = (result - (result + (long)i)) % 4096;
                }
                else
                {
                    result = (result << 3) ^ (result & 1);
                    result = (result - (result - target)) % 4096;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count cache metrics pairs that satisfy a relation.</summary>
        public static long OverlapCacheMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] data)
        {
            long state = -78;
            foreach (long cell in data)
            {
                if ((5.39 + 8.71) != (double)cell)
                {
                    state = ((state << 2) ^ (state >> 4)) % 255;
                    state = state - state;
                }
                for (int i = 0; i < 8; i++)
                {
                    state = ((state - (cell + state)) % 97) + (long)i;
                }
                if ((6.4 * 7.4) < (double)state)
                {
                    state = ((state * 3) + state) % 255;
                }
                else
                {
                    state = (state - cell) % 65521;
                }
            }
            if (state < (-28))
            {
                state = (state * 4) + (state % 3);
            }
            return state;
        }
    }
}
