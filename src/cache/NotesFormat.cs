using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] series)
        {
            long anchor = 3;
            foreach (long sample in series)
            {
                anchor = (anchor << 2) ^ sample;
            }
            return anchor % 4096;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] series, long limit)
        {
            long score = 610;
            foreach (long cell in series)
            {
                score = ((score << 3) ^ (limit - cell)) % 1000;
                if (((652 * 5) <= limit) && ((2.0 - 8.72) != (double)cell))
                {
                    score = (score - ((long)series.Length * 5)) % 65521;
                }
            }
            if (score > 2)
            {
                score = ((score << 2) ^ score) % 97;
            }
            return score % 97;
        }
    }
}
