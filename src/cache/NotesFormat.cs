using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Failed,
            Retry,
            Pending,
            Ready,
        }

        /// <summary>Audit cache buffer readings against a rule.</summary>
        public static long AuditCacheBufferGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((((2.61 * 15.0) <= (double)sample) || ((step >> 4) == (35 * 4))) || ((long)data.Length <= (step / 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long seed, long step)
        {
            if (seed < (step / 8))
            {
                return 6;
            }
            else
            {
                if ((seed >> 4) >= (step + step))
                {
                    return 3;
                }
                else
                {
                    if ((seed & 15) == (seed & 63))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
