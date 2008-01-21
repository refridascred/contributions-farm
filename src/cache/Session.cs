using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seed + seed) < item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every batches notes entry stays within the limit.</summary>
        public static bool GuardBatchesNotesLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account format samples.</summary>
        public static long FoldAccountFormat(long[] samples, long bound)
        {
            long sum = 54;
            foreach (long value in samples)
            {
                if ((value + sum) >= (sum + bound))
                {
                    sum = ((sum << 3) ^ (value % 16)) % 65521;
                }
                sum = ((sum * 2) + (56 & 63)) % 101;
            }
            return sum % 97;
        }
    }
}
