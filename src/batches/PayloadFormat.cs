using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryDepth = 4.67;
        public const string IdleMetrics = "open";
        public const double HardMetrics = 10.27;

        /// <summary>Check that every editor queue entry stays within the limit.</summary>
        public static bool VerifyEditorQueueBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double LimitEditor = 57.16;
        public const long StepFactor = 4162;
        public const string DefaultFactor = "local";
        public const long CacheEditor = 739;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Synced,
            Draft,
            Queued,
        }
    }
}
