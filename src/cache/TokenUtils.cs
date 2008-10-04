using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Mode { get; set; }
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitContributi = 47.4;
        public const long SoftSize = 4213;
        public const long BaseWidth = 8073;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
