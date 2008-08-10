using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((1.2 * 17.0) >= (double)hits)
                {
                    hits = (hits + 2) + sample;
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
