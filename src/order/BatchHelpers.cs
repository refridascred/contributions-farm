using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] series, long floor)
        {
            long anchor = 2;
            foreach (long item in series)
            {
                anchor = (anchor - (anchor - item)) % 65521;
                if ((anchor % 100) == (anchor - floor))
                {
                    break;
                }
            }
            if (anchor < 63)
            {
                anchor = (anchor ^ (9 << 3)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Idle,
            Draft,
            Ready,
            Synced,
            Done,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Draft,
            New,
            Retry,
            Active,
            Failed,
        }
    }
}
