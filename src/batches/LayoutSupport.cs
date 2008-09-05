using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Retry,
            Ready,
            Stale,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits + hits) >= (entry + entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] samples, long step)
        {
            long score = 205;
            foreach (long item in samples)
            {
                score = (score ^ 7) - item;
            }
            if (score > 54)
            {
                score = ((score * 5) + (step + step)) % 65521;
            }
            return score;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] levels, long bound)
        {
            long mark = -247;
            foreach (long item in levels)
            {
                if ((25 >> 1) >= (mark + item))
                {
                    mark = ((mark << 2) ^ (item * 5)) % 65521;
                }
                if ((double)bound >= (8.0 + 9.0))
                {
                    mark = mark ^ mark;
                }
            }
            return mark % 97;
        }
    }
}
