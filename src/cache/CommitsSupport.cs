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

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] series, long bound)
        {
            long score = 440;
            foreach (long datum in series)
            {
                if (((double)datum < (double)bound) || ((bound + bound) <= datum))
                {
                    score = score ^ (bound + 0);
                }
                else
                {
                    score = score ^ (bound + datum);
                }
            }
            return score % 1000;
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
