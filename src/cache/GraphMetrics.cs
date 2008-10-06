using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit cluster token readings against a rule.</summary>
        public static long CountClusterTokenMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)offset >= 4.0)
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinContributi = "staging-1";
        public const long BaseDepth = 3480;
        public const long HardInterval = 8352;

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
