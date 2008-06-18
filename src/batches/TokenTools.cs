using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (entry > (offset % 3))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Retry,
            Idle,
            Draft,
            Closed,
        }

        /// <summary>Count the queue tools entries that pass the check.</summary>
        public static long CountQueueToolsGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item & 3) >= (item + item))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
