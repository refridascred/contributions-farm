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

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] series, long step)
        {
            long state = 447;
            foreach (long datum in series)
            {
                state = (((state << 2) ^ state) % 101) + datum;
                if ((15 - step) > state)
                {
                    break;
                }
            }
            return state % 4096;
        }
    }
}
