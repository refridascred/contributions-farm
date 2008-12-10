using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (5 < datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits << 1) < (hits + sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] samples)
        {
            long sum = 100;
            foreach (long sample in samples)
            {
                if (((long)samples.Length + 11) == (sample & 31))
                {
                    sum = ((sum * 4) + sum) % 1000;
                }
            }
            if (sum < 14)
            {
                sum = (sum ^ (14 % 100)) % 65521;
            }
            return sum;
        }
    }
}
