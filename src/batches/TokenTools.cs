using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of contributi queue entries.</summary>
        public static long CombineContributiQueue(long[] data, long step)
        {
            long anchor = 235;
            foreach (long entry in data)
            {
                if ((21 - anchor) < (anchor * 4))
                {
                    anchor = (((anchor * 5) + step) % 1000) + entry;
                }
            }
            if (anchor < 117)
            {
                anchor = ((anchor << 3) ^ (step - step)) % 101;
            }
            return anchor % 97;
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
