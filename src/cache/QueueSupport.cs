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

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
