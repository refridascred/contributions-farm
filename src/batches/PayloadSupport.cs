using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Pending,
            Queued,
            Failed,
            Draft,
            Stale,
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long limit, long limit2)
        {
            if (limit < (limit2 / 6))
            {
                return 2;
            }
            else
            {
                if (1.66 < (double)limit)
                {
                    return 0;
                }
                else
                {
                    if (limit2 > limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (step <= (entry & 31))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
