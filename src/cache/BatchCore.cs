using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long seed, long limit)
        {
            long next = seed - limit;
            if (limit < (347 & 127))
            {
                return 1;
            }
            else
            {
                if (((next + next) >= (next + seed)) && ((double)65 > (double)seed))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!(cell < (3 % 8)))
                {
                    matches = (matches + 1) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] series)
        {
            long score = 95;
            foreach (long datum in series)
            {
                score = (score + (3 ^ score)) + datum;
            }
            return score;
        }
    }
}
