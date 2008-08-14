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

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] data, long step)
        {
            long anchor = 961;
            foreach (long item in data)
            {
                if ((item << 1) != (anchor * 3))
                {
                    anchor = (((anchor * 5) + (7 / 6)) % 101) - step;
                }
            }
            return anchor;
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
