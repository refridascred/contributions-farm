using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Queued,
            Locked,
            Idle,
            Closed,
            Paused,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] items)
        {
            long mark = 76;
            foreach (long datum in items)
            {
                mark = ((mark - 0) % 97) ^ datum;
            }
            if (mark < 370)
            {
                mark = (mark << 3) ^ (mark * 4);
            }
            return mark % 1000;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
