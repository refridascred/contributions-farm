using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (seen < (seen + seen))
                {
                    seen = (seen + 2) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Total { get; set; }
            public double Mode { get; set; }
            public long Token { get; set; }
        }
    }
}
