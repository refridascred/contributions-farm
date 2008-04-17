using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheBatches = 63.59;
        public const double BatchBatches = 15.38;
        public const string DefaultDepth = "latest-1";
        public const long CacheDepth = 5999;

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
