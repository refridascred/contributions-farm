using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Pending,
            Closed,
            New,
            Paused,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleLevel = 3170;
        public const long MinTimeout = 4965;
        public const long IdleEntry = 7569;
        public const long BatchCount = 9605;
        public const long LimitDepth = 4932;

        /// <summary>Audit buffer filter readings against a rule.</summary>
        public static long AuditBufferFilterMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((2.95 / 9.0) != (double)count)
                {
                    count = ((count + 2) ^ item) - origin;
                }
            }
            return count;
        }
    }
}
