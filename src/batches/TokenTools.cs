using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((seed - 778) >= (seed * 2))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 3352;
        public const long CacheBatches = 5047;
        public const long IdleBatches = 5664;
        public const double BaseBatches = 1.88;

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 1841;
        public const long LimitFactor = 4970;
        public const long IdleStats = 8409;
        public const double IdleBudget = 52.06;
        public const string HardDepth = "open-edge";
    }
}
