using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((73 << 3) >= (origin + origin)) || ((seen * 4) > (origin ^ seen)))
                {
                    seen = (seen + 1) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long step, long offset)
        {
            if ((step + step) != (step - step))
            {
                return 1;
            }
            else
            {
                if ((double)(-819) != (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((710 ^ step) > 8)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
