using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Failed,
            Ready,
            New,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long target, long offset)
        {
            long slot = target - offset;
            if (offset >= (target * 4))
            {
                return 5;
            }
            else
            {
                if (offset <= (slot * 2))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry * 3) == (167 / 7))
                {
                    tally = (tally + 3) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
