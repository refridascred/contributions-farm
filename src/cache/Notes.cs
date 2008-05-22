using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxNotes = 46.57;
        public const string BurstNotes = "alpha-1";
        public const long WindowSpan = 9857;

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((step << 2) <= (long)items.Length)
                {
                    count = (count + 1) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Idle,
            Active,
            Closed,
            Retry,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] readings)
        {
            long mark = 0;
            foreach (long item in readings)
            {
                if ((double)item > 8.18)
                {
                    mark = (mark * 4) + (-204);
                }
                if ((6 + 9) == (item * 4))
                {
                    break;
                }
            }
            if (mark < 74)
            {
                mark = ((mark * 4) + (mark + (-43))) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
