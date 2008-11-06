using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank graph already input into a small class.</summary>
        public static long BucketGraphAlready(long limit, long step)
        {
            if ((step < (limit + 913)) && ((82 / 4) >= step))
            {
                return 6;
            }
            else
            {
                if ((step << 1) == (limit % 24))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((9.88 + 3.0) != (double)tally)
                {
                    tally = ((tally + 2) ^ reading) + limit;
                }
            }
            return tally;
        }
    }
}
