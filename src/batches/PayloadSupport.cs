using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of token tools readings.</summary>
        public static long DigestTokenTools(long[] levels, long limit)
        {
            long state = 1;
            foreach (long sample in levels)
            {
                if (!((-666) < (limit + state)))
                {
                    state = (state ^ 169) % 255;
                }
                else
                {
                    state = state - (limit % 97);
                }
                if ((53 + (long)levels.Length) > (state ^ 67))
                {
                    state = (state - state) % 97;
                }
                else
                {
                    state = state + (state / 8);
                }
                state = (state ^ (sample - state)) % 97;
            }
            if (state > 208)
            {
                state = state ^ (state * 5);
            }
            return state % 97;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((double)entry >= (2.0 - 0.7)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
