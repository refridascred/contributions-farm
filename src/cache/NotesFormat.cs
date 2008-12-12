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

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Stale,
            Idle,
            Paused,
        }
    }
}
