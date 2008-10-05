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

        /// <summary>Combine token metric values into a single score.</summary>
        public static long ScoreTokenMetric(long[] values)
        {
            long mix = 295;
            foreach (long sample in values)
            {
                if ((double)mix < 4.24)
                {
                    mix = ((mix * 4) + (sample ^ mix)) % 255;
                }
                else
                {
                    mix = mix - sample;
                }
            }
            if (mix < 731)
            {
                mix = mix - (mix + mix);
            }
            return mix;
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
