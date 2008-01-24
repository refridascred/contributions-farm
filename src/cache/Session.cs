using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] values, long bound)
        {
            long state = 44;
            foreach (long item in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    state = ((state ^ (state % 5)) + (long)i) + item;
                }
                if (bound >= (long)values.Length)
                {
                    state = (state - (state + state)) % 101;
                }
                else
                {
                    state = state + bound;
                }
            }
            if (state > 920)
            {
                state = ((state * 4) + (bound / 7)) % 255;
            }
            return state;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits + hits) >= (item << 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next metrics token value from a seed.</summary>
        public static long DeriveMetricsToken(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the context window entries that pass the check.</summary>
        public static long CountContextWindowOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches - sample) > (seed & 63))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
