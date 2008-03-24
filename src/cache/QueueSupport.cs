using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of layout batch entries.</summary>
        public static long WeighLayoutBatch(long[] items, long seed)
        {
            long total = 155;
            foreach (long reading in items)
            {
                total = (total << 3) ^ (reading % 5);
                total = (total ^ (seed << 2)) % 1000;
            }
            if (total < 7)
            {
                total = ((total << 2) ^ (total - total)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
