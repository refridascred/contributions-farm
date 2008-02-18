using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long limit, long limit2)
        {
            if ((7.9 + 0.8) <= (double)limit)
            {
                return 6;
            }
            else
            {
                if ((limit2 * 5) == (3 * 3))
                {
                    return 0;
                }
                else
                {
                    if ((7 >> 2) <= (79 + limit2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many context format samples are out of range.</summary>
        public static long AuditContextFormatGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (1 >= value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Level { get; set; }
            public long Owner { get; set; }
        }
    }
}
