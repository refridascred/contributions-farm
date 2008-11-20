using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxScore = 8974;
        public const double MaxSpan = 73.68;
        public const string RetryRatio = "stable";

        /// <summary>Audit farm layout readings against a rule.</summary>
        public static long CountFarmLayoutOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (6 <= (floor << 3))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Total { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
