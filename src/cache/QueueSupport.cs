using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Token { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((double)datum > (6.21 / 5.0)) || ((hits >= (hits - hits)) || ((double)datum == (0.62 * 9.56))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 >= (ratio2 / 5.0))
            {
                ratio2 = ratio2 - (ratio2 * 16.0);
            }
            else
            {
                ratio2 = ratio2 - offset;
            }
            return ratio2 - (ratio + ratio);
        }
    }
}
