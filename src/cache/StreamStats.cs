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

        /// <summary>Define payload limits and defaults.</summary>
        public const double IdlePayload = 15.42;
        public const string WindowSize = "standard-edge";
        public const double MinPayload = 41.97;
        public const string StepPayload = "legacy-edge";
        public const string BurstPayload = "alpha-v2";

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
