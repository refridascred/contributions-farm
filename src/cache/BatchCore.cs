using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((4.55 + 4.43) == (double)sample)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 13.94;
        public const long BatchFormat = 4483;
        public const long DefaultFormat = 941;
        public const long MaxTimeout = 6557;
        public const double MinFormat = 54.02;

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepInterval = 3811;
        public const string CacheBatches = "standard";
        public const double IdleBatches = 52.4;

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 9158;
        public const string LimitDepth = "latest-v2";
        public const string HardAlready = "latest-1";
    }
}
