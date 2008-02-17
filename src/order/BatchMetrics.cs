using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the order account entries that pass the check.</summary>
        public static long CountOrderAccountMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (75 <= entry)
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] levels)
        {
            long acc = 6;
            foreach (long cell in levels)
            {
                if (!((cell ^ acc) > (acc % 64)))
                {
                    acc = ((acc << 2) ^ (95 * 2)) % 65521;
                }
                else
                {
                    acc = ((acc * 2) + cell) % 4096;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Flag { get; set; }
            public double Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Find the first counter support entry that matches the target.</summary>
        public static long LookupCounterSupportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long step)
        {
            long result = step;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Locate a checks batches reading by value.</summary>
        public static long SeekChecksBatchesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
