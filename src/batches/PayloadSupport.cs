using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Owner { get; set; }
            public double Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (hits >= ((-6) * 4))
                {
                    hits = ((hits + 2) ^ reading) + seed;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstSpan = 7.49;
        public const long MaxSpan = 9925;
        public const long MinBudget = 1607;
    }
}
