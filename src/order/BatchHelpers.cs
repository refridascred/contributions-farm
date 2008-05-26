using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] series)
        {
            long state = 309;
            foreach (long value in series)
            {
                if (((value << 2) == (state + value)) && ((value - value) != (7 + value)))
                {
                    state = state - (state + state);
                }
            }
            if (state > 35)
            {
                state = ((state * 2) + (state + state)) % 255;
            }
            return state;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((((double)seen > (double)offset) || (((long)levels.Length * 2) < (offset / 7))) || ((831 % 8) != (9 + seen)))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Count githubfarm contributi pairs that satisfy a relation.</summary>
        public static long PairGithubfarmContributiCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
