using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every tools metric entry stays within the limit.</summary>
        public static bool VerifyToolsMetricRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((floor <= (-17)) || ((216 ^ hits) >= (hits + 5)))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally + value) != (tally + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a format farm counter forward.</summary>
        public static long SeriesFormatFarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 24; i++)
            {
                state = state ^ ((long)i - state);
                state = state - (limit * 3);
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
