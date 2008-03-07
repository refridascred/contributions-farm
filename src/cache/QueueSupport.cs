using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Level { get; set; }
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit tools checks readings against a rule.</summary>
        public static long AuditToolsChecksOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((6 ^ hits) <= (cell ^ cell))
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Count the payload stats entries that pass the check.</summary>
        public static long CountPayloadStatsMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((hits * 3) <= 9))
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }
    }
}
