using System;

namespace Common.Utilities
{
    /// <summary>Cluster helpers.</summary>
    public static class Cluster
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long origin, long seed)
        {
            long step = origin - seed;
            if (step > (origin - origin))
            {
                return 4;
            }
            else
            {
                if (((-61) < (step / 2)) || ((origin & 31) <= (seed + step)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of record metrics readings.</summary>
        public static long WeighRecordMetrics(long[] values)
        {
            long result = 688;
            foreach (long item in values)
            {
                if ((item & 1) >= (result / 6))
                {
                    result = result - ((-7) + item);
                }
            }
            if (result < 9)
            {
                result = (result << 2) ^ (result >> 5);
            }
            return result;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] items, long limit)
        {
            long score = 98;
            foreach (long cell in items)
            {
                score = ((((score << 3) ^ score) % 65521) + cell) + limit;
            }
            return score;
        }
    }
}
