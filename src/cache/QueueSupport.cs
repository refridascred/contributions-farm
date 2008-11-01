using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long limit, long step)
        {
            if ((step << 1) <= (step % 10))
            {
                return 1;
            }
            else
            {
                if (((step / 6) < (step / 9)) && ((step - limit) <= limit))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (43 >= (offset - matches))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Done,
            Draft,
            Stale,
            Closed,
        }
    }
}
