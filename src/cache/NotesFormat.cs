using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank layout stats input into a small class.</summary>
        public static long GradeLayoutStats(long offset, long step)
        {
            if ((step >= (step / 5)) && ((double)offset == (9.9 * 9.3)))
            {
                return 5;
            }
            else
            {
                if ((4.6 - 7.15) <= (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((step * 2) < (offset * 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Done,
            New,
            Closed,
            Draft,
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Level { get; set; }
            public long Mode { get; set; }
        }
    }
}
