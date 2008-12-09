using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long HardSpan = 8626;
        public const long MaxLevel = 6398;
        public const long WindowSize = 8495;
        public const long BurstSpan = 616;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Failed,
            Locked,
            Closed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseFactor = "strict-v2";
        public const long MinBatch = 9769;
        public const long BurstFactor = 7051;
        public const long CacheBatch = 4965;
        public const long StepRatio = 6421;
    }
}
