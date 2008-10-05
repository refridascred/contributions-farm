using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Count { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count + count) <= (count >> 3))
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Retry,
            Stale,
            New,
            Draft,
        }
    }
}
