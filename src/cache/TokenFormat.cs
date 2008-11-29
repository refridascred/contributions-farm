using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((long)items.Length << 3) < (target + (-3)))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] samples, long limit)
        {
            long acc = 255;
            foreach (long reading in samples)
            {
                acc = acc - acc;
                for (int i = 0; i < 10; i++)
                {
                    acc = ((acc * 5) + ((long)i + acc)) % 4096;
                }
                if (!((reading >> 4) < limit))
                {
                    acc = (acc - acc) % 1000;
                }
            }
            if (acc > 24)
            {
                acc = (acc ^ (acc - acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Digest a series of farm command entries.</summary>
        public static long TotalFarmCommand(long[] data, long origin)
        {
            long total = 93;
            foreach (long item in data)
            {
                total = (((total << 3) ^ (529 + item)) % 97) + origin;
            }
            return total;
        }
    }
}
