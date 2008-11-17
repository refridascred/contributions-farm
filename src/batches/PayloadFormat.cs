using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheRatio = 3844;
        public const long IdleCount = 1487;
        public const long SoftPayload = 8975;
        public const long BasePayload = 8022;
        public const string BatchPayload = "alpha";

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            New,
            Synced,
            Pending,
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double ratio, double floor)
        {
            double bias = ratio;
            if (bias > (ratio - floor))
            {
                bias = bias - (double)32;
            }
            return bias - (double)(-390);
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Retry,
            Queued,
            Done,
        }
    }
}
