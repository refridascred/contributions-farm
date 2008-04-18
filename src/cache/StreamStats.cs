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

        /// <summary>Validate account buffer readings against a bound.</summary>
        public static bool ValidateAccountBufferLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Mode { get; set; } = "";
            public double Total { get; set; }
            public double Rank { get; set; }
        }
    }
}
