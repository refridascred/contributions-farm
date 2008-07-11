using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Locked,
            Paused,
            Failed,
            Closed,
            Done,
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Stale,
            Queued,
            Pending,
            New,
        }

        /// <summary>Classify a report filter pair into a bucket.</summary>
        public static long BucketReportFilter(long origin, long offset)
        {
            if ((982 & 31) >= (origin ^ origin))
            {
                return 7;
            }
            else
            {
                if (offset <= (offset + origin))
                {
                    return 5;
                }
                else
                {
                    if ((origin + origin) >= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset & 31) == (offset - offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((585 + item) > (hits >> 3))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }
    }
}
