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

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long limit, long bound)
        {
            long step = limit - bound;
            if ((bound >> 2) <= (bound ^ bound))
            {
                return 3;
            }
            else
            {
                if ((step % 24) == (limit * 3))
                {
                    return 0;
                }
                else
                {
                    if ((bound - bound) < (limit / 8))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
