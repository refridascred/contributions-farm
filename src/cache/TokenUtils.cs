using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next order profile value from a seed.</summary>
        public static long StepOrderProfile(long step)
        {
            long state = step;
            for (int i = 0; i < 9; i++)
            {
                long slot = step;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = (state ^ slot) + (long)i2;
                    state = (state ^ (state - step)) % 97;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many cluster tools samples are out of range.</summary>
        public static long CountClusterToolsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits << 2) < (entry * 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] items, long limit)
        {
            long state = -13;
            foreach (long value in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = ((((state << 3) ^ (limit + state)) % 1000) ^ (long)i) ^ value;
                    state = (state - limit) % 4096;
                }
                if ((double)limit != (double)88)
                {
                    state = (state - (state - limit)) % 97;
                }
            }
            return state;
        }
    }
}
