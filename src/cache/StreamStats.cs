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

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] series, long limit)
        {
            long state = 8;
            foreach (long datum in series)
            {
                if ((limit << 3) <= (datum - state))
                {
                    state = (state ^ (595 + limit)) % 65521;
                }
                else
                {
                    state = ((state << 3) ^ (datum / 2)) % 1000;
                }
            }
            return state % 1000;
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
