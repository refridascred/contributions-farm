using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!(696 <= (item * 5)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long limit, long floor)
        {
            if ((double)7 > (double)floor)
            {
                return 1;
            }
            else
            {
                if ((limit / 3) <= floor)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Ratio { get; set; }
            public bool Rank { get; set; }
            public long Total { get; set; }
        }
    }
}
