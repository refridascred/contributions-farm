using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxCache = "legacy-1";
        public const double LimitCache = 72.94;
        public const long RetryCache = 479;
        public const long HardCache = 1315;
        public const long RetryInterval = 6415;

        /// <summary>Define notes limits and defaults.</summary>
        public const string RetryNotes = "alpha-v2";
        public const long DefaultNotes = 7206;
        public const long BaseSpan = 3803;
        public const double CacheNotes = 44.42;
        public const long BurstNotes = 8832;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((hits / 9) > (hits << 2)) || ((double)item <= (9.5 - 17.0)))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Failed,
            Dropped,
            New,
            Pending,
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Closed,
            Dropped,
            Done,
            Pending,
            Idle,
        }
    }
}
