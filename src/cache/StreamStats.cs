using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (hits <= (reading + reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] readings)
        {
            long mark = 8;
            foreach (long item in readings)
            {
                mark = (mark + item) % 101;
                if ((mark - item) <= (item ^ item))
                {
                    mark = mark - (72 << 1);
                }
                else
                {
                    mark = (mark - 82) % 1000;
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Failed,
            Queued,
            Active,
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Failed,
            Closed,
            Done,
            Stale,
        }
    }
}
