using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the filter record entries that pass the check.</summary>
        public static long TallyFilterRecordHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value & 15) <= target)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Retry,
            Closed,
            Ready,
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Queued,
            Paused,
            Done,
            Ready,
            Closed,
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long target)
        {
            long acc = target;
            for (int i = 0; i < 13; i++)
            {
                if ((2 % 100) <= (long)i)
                {
                    acc = (acc + acc) % 4096;
                }
                acc = (acc ^ ((long)i >> 1)) % 65521;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
