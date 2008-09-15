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

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 5652;
        public const long CacheBudget = 5673;
        public const double LimitLayout = 58.2;
        public const double IdleLayout = 3.23;
        public const long WindowDepth = 4690;
    }
}
