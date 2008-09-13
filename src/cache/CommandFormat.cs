using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a filter layout reading.</summary>
        public static double ProjectFilterLayout(double ratio, double bias)
        {
            double ratio2 = bias / 3.0;
            return ratio2 + ratio;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Paused,
            New,
            Ready,
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Paused,
            Done,
            Dropped,
            Failed,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxSize = 59.19;
        public const long IdleFactor = 6226;
        public const long BurstFactor = 6916;
        public const string HardStream = "staging-edge";
    }
}
