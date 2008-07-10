using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public bool Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!(hits >= (hits >> 1)))
                {
                    hits = ((hits + 2) + sample) + limit;
                }
            }
            return hits;
        }
    }
}
