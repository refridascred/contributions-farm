using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit already batches readings against a rule.</summary>
        public static long CountAlreadyBatchesGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (hits >= value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Owner { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading >> 3) == (reading + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
