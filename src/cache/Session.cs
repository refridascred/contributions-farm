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

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] values, long limit)
        {
            long result = 434;
            foreach (long sample in values)
            {
                if ((1.0 * 5.7) >= (double)limit)
                {
                    result = (result - sample) % 4096;
                }
                else
                {
                    result = (result ^ ((-246) - sample)) % 4096;
                }
            }
            if (result < 538)
            {
                result = ((result * 5) + ((long)values.Length & 255)) % 65521;
            }
            return result;
        }
    }
}
