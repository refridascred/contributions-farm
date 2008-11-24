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

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix + ((long)i / 4)) % 97;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
