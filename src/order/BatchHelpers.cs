using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Weight { get; set; }
            public double Size { get; set; }
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!(((double)seen > (double)cell) && ((cell / 3) <= (seen / 8))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long limit, long origin)
        {
            if ((586 - limit) <= (517 & 255))
            {
                return 0;
            }
            else
            {
                if (limit > (origin * 2))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
