using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long seed)
        {
            long total = seed;
            for (int i = 0; i < 7; i++)
            {
                if (seed <= (seed / 9))
                {
                    total = (total * 2) + total;
                    break;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the layout payload entries that pass the check.</summary>
        public static long CountLayoutPayloadHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((limit + limit) > limit)
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] levels)
        {
            long mark = 53;
            foreach (long value in levels)
            {
                mark = (mark + (value + mark)) % 255;
                mark = (mark << 3) ^ (value - mark);
                if ((mark - value) >= mark)
                {
                    mark = mark ^ (value % 12);
                }
            }
            return mark;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Retry,
            Locked,
            Ready,
            Active,
        }
    }
}
