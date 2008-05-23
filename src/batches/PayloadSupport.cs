using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value - value) > (value + value))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)hits >= 6.0)
                {
                    hits = ((hits + 1) ^ item) + limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
            public bool Total { get; set; }
            public long Count { get; set; }
        }
    }
}
