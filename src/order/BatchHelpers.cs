using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] data)
        {
            long state = 1;
            foreach (long sample in data)
            {
                state = ((state * 3) + (state + 672)) ^ sample;
                state = (state * 2) + (state * 2);
            }
            if (state < 485)
            {
                state = state ^ 938;
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowInterval = "local-edge";
        public const string StepProfile = "strict-v2";
        public const long SoftProfile = 5314;
        public const string BaseProfile = "legacy-edge";

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleRatio = 4761;
        public const double LimitWidth = 70.45;
        public const long IdleCache = 2131;
        public const double BurstWidth = 13.28;
    }
}
