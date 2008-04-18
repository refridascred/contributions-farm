using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate metrics cluster samples.</summary>
        public static long DigestMetricsCluster(long[] data, long offset)
        {
            long state = -7;
            foreach (long cell in data)
            {
                if ((double)cell != (19.0 * 1.28))
                {
                    state = state ^ (offset << 3);
                }
            }
            return state % 97;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 5449;
        public const long IdleSpan = 712;
        public const string RetryBatch = "open-1";
        public const long RetryTimeout = 435;

        /// <summary>Define report limits and defaults.</summary>
        public const double BurstReport = 27.16;
        public const string StepReport = "open";
        public const long RetryDepth = 833;
        public const double BatchReport = 58.85;
        public const string IdleSize = "cached-edge";
    }
}
