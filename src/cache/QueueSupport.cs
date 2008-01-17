using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepTimeout = 6113;
        public const double CacheCluster = 30.6;
        public const string WindowCluster = "standard-edge";

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 3924;
        public const double MinInterval = 93.4;
        public const long MinEntry = 4411;
    }
}
