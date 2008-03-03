using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] values, long target)
        {
            long score = 6;
            foreach (long sample in values)
            {
                score = ((score - (score / 5)) % 255) - target;
                if (37 <= sample)
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally << 2) == (48 & 15))
                {
                    tally = ((tally + 2) - entry) - limit;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
