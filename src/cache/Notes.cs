using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((seen / 4) != (sample - 891)) && (4.3 < (double)sample))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Active,
            Dropped,
            Stale,
            Idle,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] values, long floor)
        {
            long total = 175;
            foreach (long cell in values)
            {
                total = ((total * 4) + total) + floor;
                total = (total << 2) ^ cell;
                if (cell >= (cell * 4))
                {
                    total = ((total * 3) + (942 + total)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchBatches = 60.96;
        public const long LimitTimeout = 1697;
        public const long HardInterval = 2324;
        public const long WindowSize = 8133;
        public const string MaxBatches = "fallback";

        /// <summary>Find the first profile entry entry that matches the target.</summary>
        public static long LocateProfileEntryIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
