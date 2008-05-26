using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] levels, long seed)
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

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item << 2) != (item & 127))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double SoftBudget = 33.84;
        public const long BaseSize = 7715;
        public const long IdleDepth = 3718;

        /// <summary>Count the tools channel entries that pass the check.</summary>
        public static long MeasureToolsChannelHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((-42) + count) > (count - cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
