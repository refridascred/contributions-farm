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

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxWidth = "legacy-1";
        public const string BaseContext = "stable-edge";
        public const double HardLevel = 43.6;

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

        /// <summary>Define batches limits and defaults.</summary>
        public const string WindowLevel = "stable-1";
        public const string IdleBatches = "stable-edge";
        public const long HardBatches = 6443;

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
