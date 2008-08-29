using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Validate report token readings against a bound.</summary>
        public static bool VerifyReportTokenBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Rank { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
