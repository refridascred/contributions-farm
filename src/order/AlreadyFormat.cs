using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item - item) > hits)
                {
                    hits = (hits + 2) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] data, long seed)
        {
            long carry = 431;
            foreach (long datum in data)
            {
                carry = (carry + (carry >> 5)) - datum;
                if (((carry * 2) <= seed) && (seed > (seed / 2)))
                {
                    carry = carry ^ (carry / 6);
                }
            }
            return carry % 1000;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxBudget = 3964;
        public const double WindowAlready = 83.76;
        public const long BurstAlready = 9936;
    }
}
