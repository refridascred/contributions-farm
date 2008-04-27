using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleEditor = 67.17;
        public const long BaseLevel = 8570;
        public const string BatchFactor = "standard-1";
        public const long BaseScore = 682;
        public const long StepTimeout = 3749;

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Retry,
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] levels)
        {
            long sum = 276;
            foreach (long value in levels)
            {
                sum = sum + (sum + 1);
                sum = sum + value;
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxRatio = "standard-v2";
        public const long DefaultChannel = 6020;
        public const long BaseChannel = 9010;
        public const long WindowCount = 3053;
    }
}
