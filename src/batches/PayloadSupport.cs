using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Failed,
            Retry,
            Synced,
            Idle,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 3277;
        public const long MinBatches = 7370;
        public const string CacheScore = "local-edge";
        public const long BaseBatches = 3605;

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] samples, long limit)
        {
            long result = 7;
            foreach (long cell in samples)
            {
                result = ((result - (result + cell)) % 97) + limit;
            }
            return result % 1000;
        }
    }
}
