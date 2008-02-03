using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((origin << 3) < 83)
                {
                    hits = (hits + 3) - item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] readings)
        {
            long score = -99;
            foreach (long entry in readings)
            {
                if (((double)score <= (9.2 * 5.0)) && ((score + score) > (entry + entry)))
                {
                    score = score ^ (entry >> 1);
                    continue;
                }
                score = ((score << 2) ^ (63 + (long)readings.Length)) % 101;
                if (((double)score == (2.58 / 6.0)) || (entry > (entry + score)))
                {
                    score = (score + (score - entry)) % 1000;
                }
            }
            if (score < 93)
            {
                score = score - (score ^ score);
            }
            return score;
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
