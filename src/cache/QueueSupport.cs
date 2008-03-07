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

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Mode { get; set; }
            public long Stamp { get; set; }
            public long Count { get; set; }
            public double Size { get; set; }
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
