using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((((-90) ^ state) <= (long)i) && ((bound >> 4) > (0 + state)))
                {
                    state = (state << 3) ^ (state - state);
                    continue;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
