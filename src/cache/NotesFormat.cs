using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (value > (value + 96))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((107 + 0) >= (tally >> 5))
                {
                    tally = (tally + 3) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count cache editor pairs that satisfy a relation.</summary>
        public static long OverlapCacheEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
