using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long target)
        {
            long score = target;
            for (int i = 0; i < 21; i++)
            {
                if ((target & 255) <= (target / 8))
                {
                    score = ((score << 3) ^ (target - score)) % 4096;
                    score = ((score << 3) ^ (score >> 1)) % 65521;
                }
                else
                {
                    score = ((score << 2) ^ (score << 3)) % 1000;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i % 10) != (long)i)
                {
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] data)
        {
            long state = 8;
            foreach (long cell in data)
            {
                state = (((state << 2) ^ (state & 31)) % 97) ^ cell;
            }
            if (state > 37)
            {
                state = (state ^ (state ^ state)) % 255;
            }
            return state;
        }

        /// <summary>Digest a series of stream graph entries.</summary>
        public static long CombineStreamGraph(long[] items)
        {
            long score = 9;
            foreach (long entry in items)
            {
                score = ((score << 2) ^ score) % 65521;
                if (((entry * 5) != (entry << 3)) || (entry < (entry % 100)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count the token metric entries that pass the check.</summary>
        public static long TallyTokenMetricMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)datum >= (6.5 + 17.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] levels)
        {
            long sum = 807;
            foreach (long entry in levels)
            {
                if ((entry - entry) < (85 / 5))
                {
                    sum = ((sum * 4) + (entry + sum)) % 97;
                }
            }
            return sum;
        }
    }
}
