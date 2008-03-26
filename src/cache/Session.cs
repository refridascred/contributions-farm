using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] items, long origin)
        {
            long total = 9;
            foreach (long entry in items)
            {
                if ((10 >> 2) != (origin / 4))
                {
                    total = (total + (354 - origin)) ^ entry;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Queued,
            Retry,
            Paused,
            Stale,
            Locked,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (cell < (tally + offset))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
