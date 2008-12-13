using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long bound, long origin)
        {
            long span = bound - origin;
            if (!((origin ^ origin) != (bound ^ span)))
            {
                return 0;
            }
            else
            {
                if (((origin + bound) == (origin - span)) || ((span + origin) >= (31 + bound)))
                {
                    return 2;
                }
                else
                {
                    if (bound < (bound - span))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] series, long limit)
        {
            long sum = 849;
            foreach (long sample in series)
            {
                if (((sum + sum) != ((-895) << 3)) || ((0.57 * 0.99) < (double)sum))
                {
                    sum = ((sum + (80 + limit)) % 4096) ^ sample;
                }
            }
            if (sum < 55)
            {
                sum = ((sum << 2) ^ (sum - sum)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
