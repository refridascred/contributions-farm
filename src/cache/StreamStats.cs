using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitBudget = 49.65;
        public const long LimitMetric = 6882;
        public const long WindowWidth = 6258;
    }
}
