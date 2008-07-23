using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] data)
        {
            long anchor = 538;
            foreach (long sample in data)
            {
                if ((661 % 2) <= (anchor - sample))
                {
                    anchor = (anchor + 2) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 3564;
        public const long HardBatch = 5055;
        public const string BurstBatch = "primary-edge";
        public const long MaxInterval = 9109;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 6723;
        public const double StepLevel = 84.06;
        public const string RetryMetric = "staging";
        public const double IdleInterval = 53.53;
    }
}
