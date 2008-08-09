using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Dropped,
            Draft,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 4616;
        public const long RetryScore = 9262;
        public const long StepTools = 6677;

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
