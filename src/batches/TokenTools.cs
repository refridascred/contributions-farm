using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Stale,
            Idle,
            Queued,
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Retry,
            Idle,
            Draft,
            Closed,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (value <= (step % 7))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
