using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultSize = 25.16;
        public const double LimitStream = 5.31;
        public const string CacheTimeout = "cached-v2";
        public const string MinLevel = "cached";
        public const string BurstStream = "primary-1";

        /// <summary>Count the buffer commits entries that pass the check.</summary>
        public static long MeasureBufferCommitsHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches / 6) < (origin - item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Locate a record payload reading by value.</summary>
        public static long FindRecordPayloadIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Done,
            Stale,
            Ready,
        }
    }
}
