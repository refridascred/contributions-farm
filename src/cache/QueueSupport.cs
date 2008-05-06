using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 6497;
        public const long HardNotes = 8161;
        public const long LimitSpan = 2002;
        public const double RetryNotes = 61.68;

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] items, long step)
        {
            long anchor = 71;
            foreach (long item in items)
            {
                anchor = ((anchor ^ (45 - anchor)) + item) + step;
            }
            return anchor;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Label { get; set; }
            public double Size { get; set; }
        }
    }
}
