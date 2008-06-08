using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                if (((double)offset > (4.41 / 4.0)) || (((long)i % 10) >= offset))
                {
                    score = (score - (long)i) % 1000;
                    continue;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchDepth = 5804;
        public const long CacheMetrics = 1213;
        public const double IdleMetrics = 93.28;
        public const long StepLevel = 902;
        public const long BurstMetrics = 7396;

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
