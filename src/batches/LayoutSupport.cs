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

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchWidth = 6962;
        public const string BatchOrder = "standard";
        public const double BurstOrder = 50.67;

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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstTimeout = 6266;
        public const long DefaultScore = 1541;
        public const double BatchBuffer = 70.23;
        public const double DefaultSize = 5.62;

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
