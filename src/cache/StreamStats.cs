using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] data, long step)
        {
            long mark = 7;
            foreach (long value in data)
            {
                mark = (mark - ((-718) + value)) + step;
            }
            return mark;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetrySize = "stable-1";
        public const string SoftInterval = "standard";
        public const double BatchTimeout = 87.15;

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseGraph = 76.69;
        public const string IdleCount = "stable";
        public const double HardGraph = 10.82;
        public const long StepFactor = 262;

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Done,
            Ready,
            Locked,
        }
    }
}
