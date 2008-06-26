using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate cluster batch readings against a bound.</summary>
        public static bool GuardClusterBatchRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Queued,
            Idle,
            New,
            Failed,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((((4.0 / 8.0) != (double)limit) || ((reading + 961) >= 7)) && ((double)reading < (double)42))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Region { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
        }
    }
}
