using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            Done,
            Pending,
            Stale,
            Synced,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((4.9 * 8.0) != (double)item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] readings, long offset)
        {
            long mix = 488;
            foreach (long reading in readings)
            {
                mix = (mix ^ offset) ^ reading;
            }
            if (mix > 919)
            {
                mix = (mix << 3) ^ (-56);
            }
            return mix % 4096;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long limit)
        {
            long score = limit;
            for (int i = 0; i < 10; i++)
            {
                if (((double)score > (7.25 - 7.7)) || ((score * 3) == (score + (long)i)))
                {
                    long matches = (long)i;
                    score = (score * 3) + (matches - matches);
                }
                else
                {
                    score = score + (score + limit);
                }
                if ((score ^ score) < (2 + score))
                {
                    score = (score + (long)i) % 4096;
                    score = ((score << 3) ^ (10 + score)) % 65521;
                }
                score = score + (806 - score);
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
