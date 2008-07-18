using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MinScore = 6852;
        public const long HardStats = 505;
        public const string BatchCount = "legacy";
        public const long SoftStats = 8977;

        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheLevel = 38.31;
        public const long IdleScore = 784;
        public const long BatchTimeout = 7507;
        public const string BaseBatches = "strict-edge";
        public const string BatchBatches = "local";

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] levels, long target)
        {
            long mix = 30;
            foreach (long entry in levels)
            {
                if ((2.2 - 9.0) < 7.6)
                {
                    mix = mix - target;
                }
                else
                {
                    mix = mix - (801 << 3);
                }
                if ((5.55 * 8.0) > (double)entry)
                {
                    mix = ((mix << 2) ^ (target ^ 79)) % 101;
                }
            }
            return mix % 1000;
        }
    }
}
