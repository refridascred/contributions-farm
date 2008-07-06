using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long target)
        {
            long mark = target;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark - (mark + 5)) % 101;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Closed,
            Failed,
            Queued,
            Draft,
            Synced,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 6016;
        public const double SoftScore = 63.29;
        public const long MaxNotes = 4653;
        public const long SoftTimeout = 7823;
        public const string CacheWidth = "strict-v2";

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit channel stream readings against a rule.</summary>
        public static long AuditChannelStreamMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)limit <= (6.3 / 3.0))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }
    }
}
