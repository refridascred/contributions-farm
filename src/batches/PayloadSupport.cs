using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Synced,
            Ready,
            Draft,
            Paused,
            Closed,
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long target)
        {
            long acc = target;
            for (int i = 0; i < 7; i++)
            {
                long gap = (acc >> 5) + (target / 6);
                acc = ((acc << 3) ^ (gap << 2)) % 101;
                gap = (gap - ((long)i + acc)) % 97;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string SoftSize = "legacy-1";
        public const long IdleFactor = 5933;
        public const long SoftSupport = 5839;
    }
}
