using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 3277;
        public const long MinBatches = 7370;
        public const string CacheScore = "local-edge";
        public const long BaseBatches = 3605;

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchTimeout = "latest-1";
        public const long SoftScore = 37;
        public const long BurstBudget = 9546;
        public const long DefaultToken = 3440;
        public const string SoftCount = "standard-1";
    }
}
