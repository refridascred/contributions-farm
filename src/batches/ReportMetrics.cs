using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 4771;
        public const double IdleCount = 70.05;
        public const long CacheRatio = 2152;
        public const long BaseLevel = 8414;
        public const long MaxRatio = 8647;

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] data, long origin)
        {
            long mix = 358;
            foreach (long item in data)
            {
                mix = ((mix ^ (origin >> 1)) % 97) ^ item;
            }
            if (mix < 38)
            {
                mix = mix + (long)data.Length;
            }
            return mix;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseBudget = 28.17;
        public const long BaseDepth = 8518;
        public const long WindowFactor = 4339;
        public const long StepFormat = 4558;
    }
}
