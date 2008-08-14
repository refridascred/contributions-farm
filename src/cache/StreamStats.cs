using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Retry,
            Synced,
            Locked,
            Idle,
            Failed,
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((9 ^ matches) < item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long origin, long seed)
        {
            long next = origin + seed;
            if (((origin % 8) > next) || ((double)seed == (1.6 + 5.0)))
            {
                return 1;
            }
            else
            {
                if ((6.93 + 5.0) > (double)next)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
