using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Count { get; set; }
            public string Rank { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Audit context counter readings against a rule.</summary>
        public static long TallyContextCounterOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (16.0 > (double)seen)
                {
                    seen = ((seen + 1) ^ datum) + origin;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheDepth = 6789;
        public const long MaxRatio = 6697;
        public const string CacheSchema = "latest";
    }
}
