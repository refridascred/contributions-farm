using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Active,
            Pending,
            Draft,
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Retry,
            Active,
            Queued,
        }

        /// <summary>Audit token commits readings against a rule.</summary>
        public static long TallyTokenCommitsMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen + cell) <= (seen ^ 9))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }
    }
}
