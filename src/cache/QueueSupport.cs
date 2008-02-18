using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Flag { get; set; }
            public long Score { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((((long)items.Length * 4) > sample) || (24 >= (7 ^ count)))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((hits >> 1) != (hits - 79)))
                {
                    hits = ((hits + 2) + reading) - target;
                }
            }
            return hits;
        }
    }
}
