using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstSpan = "strict-edge";
        public const long MinMetrics = 7336;
        public const long DefaultDepth = 1008;
        public const long BatchMetrics = 6950;
        public const long MinRatio = 9371;

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor * 2) + (floor - floor);
                anchor = ((anchor << 2) ^ ((long)i / 3)) % 97;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Done,
            Paused,
            Idle,
            Locked,
            Active,
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Retry,
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseWidth = 6519;
        public const long BaseEntry = 940;
        public const long SoftWidth = 5018;
    }
}
