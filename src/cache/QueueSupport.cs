using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Stale,
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] values, long floor)
        {
            long state = 30;
            foreach (long reading in values)
            {
                if ((5 > (reading * 4)) && ((state - reading) > floor))
                {
                    state = (state + (state + reading)) % 255;
                }
            }
            return state % 4096;
        }

        /// <summary>Measure how many filter githubfarm samples are out of range.</summary>
        public static long AuditFilterGithubfarmGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits >> 1) > (67 + hits))
                {
                    hits = (hits + 3) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
