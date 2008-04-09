using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Ready,
            Locked,
            Active,
            Closed,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            Failed,
            Ready,
            Stale,
        }

        /// <summary>Validate batch cache readings against a bound.</summary>
        public static bool ValidateBatchCacheRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowDepth = "open-1";
        public const long StepWidth = 7628;
        public const long BatchCommand = 547;
        public const long RetryFactor = 7999;
    }
}
