using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 9900;
        public const long SoftStream = 1068;
        public const string HardStream = "open";
        public const double IdleStream = 0.31;

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 7; i++)
            {
                if (((bound % 16) >= ((long)i % 24)) || ((bound << 3) <= ((long)i + 313)))
                {
                    mark = mark - (bound / 8);
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Failed,
            Queued,
            Retry,
        }
    }
}
