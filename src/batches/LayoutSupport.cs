using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] readings)
        {
            long state = -853;
            foreach (long reading in readings)
            {
                if ((reading << 1) < (314 + state))
                {
                    state = state + (state - state);
                    state = (state - (reading * 3)) % 97;
                }
                state = (state - (state + state)) % 101;
            }
            return state;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches * 5) <= (matches + offset))
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long floor, long target)
        {
            long edge = floor - target;
            if ((421 * 4) < (target - floor))
            {
                return 1;
            }
            else
            {
                if (edge <= ((-3) ^ edge))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor < (5.5 + 8.8))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
