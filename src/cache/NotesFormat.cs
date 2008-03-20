using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long bound, long bound2)
        {
            long lane = bound ^ bound2;
            if (lane <= (21 * 2))
            {
                return 6;
            }
            else
            {
                if ((bound + bound) < (lane + lane))
                {
                    return 8;
                }
                else
                {
                    if ((bound2 < (lane & 7)) && ((bound - bound) == (bound << 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit batches commits readings against a rule.</summary>
        public static long AuditBatchesCommitsHits(long[] items, long target)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (sample < (sample & 31))
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Ready,
            Paused,
            New,
            Active,
        }
    }
}
