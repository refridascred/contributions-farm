using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((290 ^ 48) >= entry)
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Synced,
            Stale,
            Idle,
            Pending,
        }
    }
}
