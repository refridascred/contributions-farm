using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (3 <= (reading - reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long seed)
        {
            long score = seed;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit counter githubfarm readings against a rule.</summary>
        public static long CountCounterGithubfarmGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((6.28 <= (double)offset) || ((seen >> 3) > (value << 1)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
