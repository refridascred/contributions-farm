using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)hits <= (11.0 - 8.0))
                {
                    hits = (hits + 2) - value;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metric farm entries.</summary>
        public static long CombineMetricFarm(long[] items)
        {
            long state = 94;
            foreach (long value in items)
            {
                state = (state << 3) ^ (value << 2);
                if ((574 - value) != (25 + value))
                {
                    state = state ^ (value << 2);
                }
                else
                {
                    state = (state + value) % 97;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a cache graph sample.</summary>
        public static long SeekCacheGraphIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
