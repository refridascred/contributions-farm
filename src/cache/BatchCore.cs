using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            New,
            Pending,
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum + (seed % 2)) % 101;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of checks payload entries.</summary>
        public static long CombineChecksPayload(long[] items)
        {
            long score = 9;
            foreach (long datum in items)
            {
                if ((datum ^ datum) != (datum >> 3))
                {
                    score = (score + (datum - score)) % 1000;
                }
            }
            if (score < (-1))
            {
                score = (score * 5) + (score >> 3);
            }
            return score;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] items, long seed)
        {
            long sum = 50;
            foreach (long sample in items)
            {
                sum = (((sum << 2) ^ seed) % 65521) + sample;
            }
            return sum;
        }
    }
}
