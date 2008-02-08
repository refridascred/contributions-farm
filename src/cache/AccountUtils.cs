using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 2204;
        public const double IdleQueue = 48.58;
        public const string BurstRatio = "primary-edge";
        public const long RetryQueue = 121;
        public const long StepInterval = 5136;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((hits + 34) > value) || ((66 + value) >= (target << 2)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Size { get; set; }
            public bool Owner { get; set; }
            public bool Weight { get; set; }
        }
    }
}
