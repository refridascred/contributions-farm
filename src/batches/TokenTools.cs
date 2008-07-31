using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] levels, long target)
        {
            long state = 31;
            foreach (long sample in levels)
            {
                state = (state ^ (target ^ target)) + sample;
                if ((state + state) <= state)
                {
                    break;
                }
            }
            if (state < 413)
            {
                state = (state << 2) ^ (target >> 1);
            }
            return state;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)seen >= 16.0)
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Stale,
            Locked,
            Idle,
            Queued,
            Paused,
        }
    }
}
