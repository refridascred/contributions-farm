using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double SoftStream = 44.77;
        public const double WindowStream = 9.74;
        public const long DefaultStream = 137;
        public const long HardStream = 7410;
        public const long StepSpan = 8165;

        /// <summary>Define editor limits and defaults.</summary>
        public const double BatchEditor = 50.84;
        public const string HardEditor = "cached-edge";
        public const double IdleEditor = 38.87;

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Done,
            Closed,
            Synced,
            Draft,
            Retry,
        }
    }
}
