using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank stats githubfarm input into a small class.</summary>
        public static long RankStatsGithubfarm(long target, long origin)
        {
            if ((double)323 >= (double)origin)
            {
                return 3;
            }
            else
            {
                if ((4.1 + 8.02) > (double)target)
                {
                    return 4;
                }
                else
                {
                    if ((origin * 3) < (origin - origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry < (entry & 7)) && ((entry + entry) < entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] readings, long offset)
        {
            long score = -77;
            foreach (long datum in readings)
            {
                score = (score ^ (offset ^ (long)readings.Length)) % 97;
                if ((double)(-1) <= (double)offset)
                {
                    score = ((score << 3) ^ datum) % 65521;
                }
            }
            return score;
        }
    }
}
