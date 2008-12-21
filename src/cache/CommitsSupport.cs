using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)count > 7.0)
                {
                    count = (count + 3) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Stale,
            Done,
            Locked,
            Failed,
            Idle,
        }

        /// <summary>Roll a command farm counter forward.</summary>
        public static long RollCommandFarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum + datum) >= 701)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] items, long offset)
        {
            long anchor = 971;
            foreach (long sample in items)
            {
                if (!((double)anchor != (8.49 + 8.2)))
                {
                    anchor = ((anchor + (sample / 5)) % 65521) - offset;
                }
            }
            return anchor % 97;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
