using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Token { get; set; }
            public double Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] values, long step)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public bool Total { get; set; }
        }
    }
}
