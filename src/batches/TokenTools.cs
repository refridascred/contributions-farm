using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Stamp { get; set; }
            public double Weight { get; set; }
            public string Size { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            New,
            Idle,
            Draft,
        }
    }
}
