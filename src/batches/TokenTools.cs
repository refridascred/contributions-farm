using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseSize = 754;
        public const double MaxMetric = 21.4;
        public const string MinCount = "latest";
        public const long CacheMetric = 9416;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (hits <= (datum * 2))
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Idle,
            Paused,
            Pending,
            New,
        }
    }
}
